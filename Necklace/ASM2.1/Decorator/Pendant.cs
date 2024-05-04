using System;
namespace Necklace.ASM2.Decorator
{
    public class Pendant : NecklaceDecorator
    {
        private const int MaxQuantity = 5;

        public Pendant(Necklace necklace, int quantity, int price) : base(necklace, quantity, price)
        {
            if (quantity > MaxQuantity)
            {
                throw new ArgumentException("Pendant quantity exceeds the limit.");
            }
        }
        public Pendant(Necklace necklace) : base(necklace)
        {

        }

        public override string GetName()
        {
            return base.GetName() + " with Pendant";
        }

        public override double GetWeight()
        {
            return base.GetWeight() + 0.5; 
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " with a pendant.";
        }

        public override double GetPrice()
        {
            return 50000000;
        }

    }
}

