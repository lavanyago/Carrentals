using System;

namespace carrentals.Models.Storage.EFModels
{
    public class HakuCAR
    {
        public Guid CarId { get; set; }
        public string Name { get; set; } 

        public string Model { get; set; }

        public int Year { get; set; }

        public string Type { get; set; }

        public bool ISrented { get; set; }
        public Guid UserId { get; set; }
    }
}