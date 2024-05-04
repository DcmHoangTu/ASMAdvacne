using System;
namespace Necklace.ASM2.Material
{
    public class Gold : Necklace
    {
        public override string GetName()
        {
            return "Gold Necklace";
        }

        public override double GetWeight()
        {
            return 10.0;
        }

        public override string GetMaterial()
        {
            return "Gold";
        }

        public override string GetDescription()
        {
            return "A beautiful gold necklace.";
        }

        public override double GetPrice()
        {
            return 100000000;
        }
    }
}

