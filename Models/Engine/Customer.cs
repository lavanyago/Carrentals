using System;

namespace carrentals.Models.Engine
{
    public class Customer
    {
         public Customer(string firstName, string lastName, string license, DateTime DOB)
    {
        custId = Guid.NewGuid();
        firstname = firstName;
        lastname = lastName;
        dlId = license;
        Birthdate = DOB;
        JoinDate = DateTime.Now;

    }    
    public Customer(string firstName, string lastName, string license, DateTime DOB, int carstaken)
    {
        custId = Guid.NewGuid();
        firstname = firstName;
        lastname = lastName;
        dlId = license;
        Birthdate = DOB;
        JoinDate = DateTime.Now;
        CarsTaken = carstaken;
    }    
        public Customer(Guid custId, string dlId, DateTime joinDate, DateTime birthdate, int carsTaken) 
        {
            this.custId = custId;
                this.dlId = dlId;
                this.JoinDate = joinDate;
                this.Birthdate = birthdate;
                this.CarsTaken = carsTaken;
               
        }
            public Guid custId { get; private set; }
    public string firstname { get;  set; }
    public string lastname { get;  set; }
    public string dlId { get; private set; }
    public DateTime JoinDate { get; private set; }
    public DateTime Birthdate { get; set; }
    public int CarsTaken { get; private set;}
    public static readonly int MaxCars_Allowed =3;
    public string FullName 
        { 
            get 
            {
                return $"{lastname}, {firstname}";
            } 
        }
    public int age
    {
        get{
            return (DateTime.Now.Year - Birthdate.Year);
        }
    }    
    public bool IsEligible 
    { 
        get
        {
        if(age>=18)
        return true;
        else 
        return false;
        } 
    }           
    public int daysbeingmember
    {
        get 
        {
            return (DateTime.Now - JoinDate).Days;
        }
    }
    public void rentcar(Guid custID)
    {
        if(IsEligible && CarsTaken<MaxCars_Allowed)
        {
            CarsTaken++;
        }
        else
        {
            throw new Exception ($"Customer{custID}, can not rent any more cars ");
        }
    }

    public void returncar(Guid custID)
    {
        if(CarsTaken>0)
        {
            CarsTaken--;
        }
        else
        {
            throw new Exception ($"customer{custID} has no books to return");
        }
    }

    public override string ToString()
    {
        string details = $"\n....Customer{custId} .....\n";
        details += $"Name: {FullName}\n";
        details += $"Number of Cars Rented: {CarsTaken}";
        details += $"daysbeingmember{daysbeingmember}";

        return details;
    }
    }
}