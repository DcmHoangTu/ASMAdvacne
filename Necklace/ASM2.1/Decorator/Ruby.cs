using System;
namespace Necklace.ASM2.Decorator
{
    public class Ruby : NecklaceDecorator
    {
        private const int MaxQuantity = 20;

        public Ruby(Necklace necklace, int quantity, int price) : base(necklace, quantity, price)
        {
            if (quantity > MaxQuantity)
            {
                throw new ArgumentException("Ruby quantity exceeds the limit.");
            }
        }

        public Ruby(Necklace necklace) : base(necklace) { }

        public override string GetName()
        {
            return base.GetName() + " with Ruby";
        }

        public override double GetWeight()
        {
            return base.GetWeight() + 1.0; 
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " adorned with a ruby.";

        }

        public override double GetPrice()
        {
            return 250000000;
        }
    }
}