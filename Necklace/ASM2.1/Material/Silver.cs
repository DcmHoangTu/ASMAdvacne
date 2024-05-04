using System;
namespace Necklace.ASM2.Material
{
    public class Silver : Necklace
    {
        public override string GetName()
        {
            return "Silver Necklace";
        }

        public override double GetWeight()
        {
            return 10.0;
        }

        public override string GetMaterial()
        {
            return "Silver";
        }

        public override string GetDescription()
        {
            return "A beautiful silver necklace.";
        }

        public override double GetPrice()
        {
            return 50000000;
        }
    }
}

