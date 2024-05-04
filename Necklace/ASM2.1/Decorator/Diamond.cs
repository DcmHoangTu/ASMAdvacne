using System;
namespace Necklace.ASM2.Decorator
{
    public class Diamond : NecklaceDecorator
    {
        private const int MaxQuantity = 20;


        public Diamond(Necklace necklace, int quantity, int price) : base(necklace, quantity, price)
        {
            if (quantity > MaxQuantity)
            {
                throw new ArgumentException("Diamond quantity exceeds the limit.");
            }
        }
        public Diamond(Necklace necklace) : base(necklace)
        {
        }

        public override string GetName()
        {
            return base.GetName() + " with Diamonds";
        }

        public override double GetWeight()
        {
            return base.GetWeight() + 2.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " adorned with diamonds.";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 360000000;
        }

    }
}

