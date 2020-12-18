using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using carrentals.Models.Engine;
using carrentals.Models.Storage;
using carrentals.Models.Storage.EFModels;

namespace carrentals.Models.Storage
{
    public class RentstorageEF : Istorerent
    {
        private ApplicationContext _context;

        public RentstorageEF(ApplicationContext context)
         {
            _context = context;
        }

       public void createR (Rent newrent)
       {
           var rentdb = ConvertToDb(newrent);
            _context.Rents.Add(loanDb);
            _context.SaveChanges();
       }


      public  Rent getbyCarId (Guid carid, Guid userId)
      {
           var rentdb = _context.Rents
                .AsNoTracking()
                .Include(x => x.customer)
                .Include(x => x.car)
                .First(x => x.carId == carid && x.IsReturned == false && x.UserId == userId);
            
            var rent = ConvertFromDb(rentdb);
            return rent;
      }


      public void updateR (Rent updatedrent)
      {
           var rentdb = ConvertToDb(updatedrent);
            _context.Rents.Update(rentdb);
            _context.SaveChanges();

      }

      public List <Customer> GetALL(Guid userId)
      {

      }

           private static EFModels.Loan ConvertToDb(Loan loan) {
            return new EFModels.Loan() {
                LoanId = loan.Id,
                BookId = loan.Book.Id,
                PatronId = loan.Patron.Id,
                IsReturned = loan.IsReturned,
                UserId = loan.UserId
                //Book = BookStorageEF.ConvertToDb(loan.Book),
                //Patron = PatronStorageEF.ConvertToDb(loan.Patron),
            };
        }

        private static Rent ConvertFromDb(EFModels.Rent rentdb) {
            return new Rent(
                rentdb.Id, 
                CustomerstorageEF.ConvertFromDb(rentdb.Customer), 
               CarstorageEF.ConvertFromDb(rentdb.HakuCAR), 
                rentdb.IsReturned,
                rentdb.UserId);
        }
    }
}