using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using carrentals.Models.Engine;
using carrentals.Models.Storage;
using carrentals.Models.Storage.EFModels;



namespace carrentals.Models.Storage
{
    public class CustomerstorageEF : Istorecustomer

    {
          private ApplicationContext _context;
 
    public CustomerstorageEF ( ApplicationContext context ) 
    {
            _context = context;
    }

      public void createC (Customer newcust)
      { 
          var custdb = ConvertToDb(newcust);
            _context.CustomerEF.Add(patronDb);
            _context.SaveChanges();

      }
      public Customer getbyIDC (Guid ID, Guid userId)
      {
              var custdb = _context.CustomerEF
                .AsNoTracking()
                .First(x => x.CustId == id && x.UserId == userId);
            
            var cust = ConvertFromDb(custdb);
            return cust;
      }
      public void updateC (Customer updatedCust)
      {
          var custdb = ConvertToDb(updatedCust);
            _context.CustomerEF.Update(custdb);
            _context.SaveChanges();
      }
      public List <Customer> GetALL(Guid userId)
      { 
                   return _context.customer
                .AsNoTracking()
                .Where(x => x.UserId == userId)
                .Select(x => ConvertFromDb(x))
                .ToList();

      }



        public static Customer ConvertFromDb(EFModels.Customer custdb)
         {
            return new EFModels.Customer(
                custdb.custId,
                custdb.firstname,
                custdb.lastname,
                custdb.dlId,
                custdb.JoinDate,
                custdb.Birthdate,
                custdb.CarsTaken,
                custdb.UserId
            

            );
        }

        public static EFModels.Customer ConvertToDb(Customer custdb)
         {
            return new EFModels.Customer()
                {
               custId = custdb.custId,
                firstname = custdb.firstname,
                lastname = custdb.lastname,
                dlId = custdb.dlId,
                JoinDate = custdb.JoinDate,
                Birthdate = custdb.Birthdate,
                CarsTaken = custdb.CarsTaken,
                UserId = custdb.UserId
            
        };
         }

    }
}