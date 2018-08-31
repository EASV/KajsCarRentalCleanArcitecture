
namespace InnoTech.Core.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public CarMake Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }
}
