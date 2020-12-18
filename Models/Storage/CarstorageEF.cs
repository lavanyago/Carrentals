
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using carrentals.Models.Engine;
using carrentals.Models.Storage;
using carrentals.Models.Storage.EFModels;



namespace carrentals.Models.Storage
{
   public class CarstorageEF : Istorecar
    {
        private ApplicationContext _context;
 
    public CarstorageEF ( ApplicationContext context ) 
    {
            _context = context;
    }

    public void createCar (Hakucar newcar)
    {
        var carmodel = ConvertToDb(newcar);
        _context.HakuCAR.Add(carmodel);
        _context.SaveChanges();
    }


    public void updateCar (Hakucar updatedCar)
    {
        var cardb = ConvertToDb(updatedCar);

        _context.SaveChanges();
    }


        public Hakucar getbyIDCar (Guid ID, Guid userid)
        {
            var carfromdb = _context.HakuCAR.AsNoTracking().Where(x => x.IsDeleted == false && x.UserId == x.userid);

            var car = CovertFromDb(carfromdb);

            return car;                
        }
        
        public List <Hakucar> GetALLcar(Guid userid)
        {
            return _context.HakuCAR
                    .AsNoTracking().Where(x => x.IsDeleted == false && x.UserId == x.userid)
                    .Select(x=> CovertFromDb(x))
                    .ToList();
        }
       public void deletecar (Hakucar carid, Guid userid)
       {
           var carfromdb = _context
                            .AsNoTracking()
                            .First(x => x.CarId == carid && x.UserId == userid);
            carfromdb.IsDeleted = true;
            _context.HakuCAR.updateCar(carfromdb);
            _context.SaveChanges;
       }

        public static Hakucar ConvertFromDb(EFModels.HakuCAR carDb)
               {
            return new Hakucar(
                carDb.CarId,
                carDb.Name,
                carDb.Model,
                carDb.Year,
                carDb.Type,
                carDb.ISrented,
                carDb.UserId,
                carDb.IsDeleted 
            );
        }

        public static EFModels.HakuCAR ConvertToDb( Hakucar car) {
            return new EFModels.HakuCAR() {
                CarId = car.CarId ,
                Name = car.Name ,
                Model = car.Model ,
                Year =  car.Year ,
                Type = car.Type ,
                ISrented = car.ISrented ,
                UserId = car.UserId,
                IsDeleted = car.IsDeleted
            };
        }
    }
}

