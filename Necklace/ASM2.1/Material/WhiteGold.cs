using System;
namespace Necklace.ASM2.Material
{
    public class WhiteGold : Necklace
    {
        public override string GetName()
        {
            return "WhiteGold Necklace";
        }

        public override double GetWeight()
        {
            return 10.0;
        }

        public override string GetMaterial()
        {
            return "WhiteGold";
        }

        public override string GetDescription()
        {
            return "A beautiful Whitegold necklace.";
        }

        public override double GetPrice()
        {
            return 80000000;
        }
    }
}

