using System;

namespace carrentals.Models.Engine
{
    public class Hakucar
    {
         public Guid carId { get; private set; }
        public string name { get;  set; }
        public string model { get; private set; }
        public int year { get;  set; }
        public string type { get; private set; }
        public bool IsRented { get; private set; }
         public bool IsDeleted { get; set; }

         public Guid UserId { get; set; }
        
        public void Rentcar() 
        {
            if (!IsRented) 
            {
                IsRented = true;
            } 
            else 
            {
                throw new Exception($"Car {carId} is already rented!");
            }
        }

         
        public void returncar()
        {
            if(IsRented)
        {
            IsRented = false;
        }
        else
        {
            throw new Exception($"Car {carId} is already returned!");
        }
        }
        public override string ToString()
        {
            string details =$"\n.... Car{carId} ....\n";
            details+= $"name:{name}\n";
            details+= $"model:{model}\n";
            details+= $"year:{year}\n";
            details+= $"type:{type}\n";
            details+= $"isrented:{IsRented}\n";
            details+= ".............\n";
            return details;

        }
    }
}