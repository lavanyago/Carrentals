using System;

namespace carrentals.Models.Storage.EFModels
{
    public class CustomerEF
    {
        public Guid CustID { get; set; }
        public string Firstname { get;  set; }
        public string Lastname { get;  set; }
        public string DlId { get;  set; }
        public DateTime Joindate { get;  set; }
        public DateTime BirthDate { get; set; }
        public int Carstaken { get;  set;}
        public Guid UserId { get; set; }
    }
}