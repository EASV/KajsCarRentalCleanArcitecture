using System;

namespace InnoTech.Core.Entities
{
    public class CarMake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Designer { get; set; }
        public int InitialProductionCount { get; set; }
    }
}