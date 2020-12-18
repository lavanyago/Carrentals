using System;

namespace carrentals.Models.Storage.EFModels
{
    public class Rent
    {
        public Guid ID { get;  set;}
        public Guid carId { get; set; }
        public HakuCAR  car { get; set; }
        public Guid custId { get; set; }
        public Customer customer { get;  set; }
        public bool IsReturned { get;  set; }
         public Guid UserId { get; set; }
    }
}