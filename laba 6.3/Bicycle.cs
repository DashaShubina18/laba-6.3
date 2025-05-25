
namespace laba6_3
{
    public class Bicycle : BaseBicycle
    {
        public Bicycle() : base() { }

        public Bicycle(string model, int year, string colour, double price,
            int frameLoadCapacity, double weight, bool wasUsed, bool wasDamaged)
            : base(model, year, colour, price, frameLoadCapacity, weight, wasUsed, wasDamaged)
        { }

        public override double CalculateMaxPassengerWeight()
        {
            return FrameLoadCapacity - Weight;
        }
    }
}
