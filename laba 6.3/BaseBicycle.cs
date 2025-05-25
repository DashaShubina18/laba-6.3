
namespace laba6_3
{
    public abstract class BaseBicycle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public double Price { get; set; }
        public int FrameLoadCapacity { get; set; }
        public double Weight { get; set; }
        public bool WasUsed { get; set; }
        public bool WasDamaged { get; set; }

        public BaseBicycle() { }

        public BaseBicycle(string model, int year, string colour, double price,
            int frameLoadCapacity, double weight, bool wasUsed, bool wasDamaged)
        {
            Model = model;
            Year = year;
            Colour = colour;
            Price = price;
            FrameLoadCapacity = frameLoadCapacity;
            Weight = weight;
            WasUsed = wasUsed;
            WasDamaged = wasDamaged;
        }

        public abstract double CalculateMaxPassengerWeight();
    }
}
