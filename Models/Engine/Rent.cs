using System;


namespace carrentals.Models.Engine
{
    public class Rent
    {
         public Rent (Customer cust, Hakucar caar)
        {
            Id= Guid.NewGuid();
            customer= cust;
            car = caar;
            IsReturned = false;
        }
         public Rent (Guid ID, Customer cust, Hakucar caar, bool isreturned)
        {
            Id= ID;
            customer = cust;
            car = caar;
            IsReturned = isreturned;
        }

        public Guid Id { get; private set;}
        public Customer customer { get;  set; }
        public Hakucar car { get;  set; }
        public bool IsReturned { get;  set; }
    }
}
