using System;
namespace Necklace.ASM2
{
    public abstract class NecklaceDecorator : Necklace
    {
     
        protected Necklace necklace;
        protected int quantity;

        protected double price;

        public NecklaceDecorator(Necklace necklace, int quantity, int price)
        {
            this.necklace = necklace;
            this.quantity = quantity;
            this.price = price;
        }

        public NecklaceDecorator(Necklace necklace)
        {
            this.necklace = necklace;
        }

        public override string GetName()
        {
            return necklace.GetName();
        }

        public override double GetWeight()
        {
            //return necklace.GetWeight();
            if (necklace != null)
            {
                return necklace.GetWeight();
            }
            else
            {
                // Xử lý khi necklace là null, ví dụ: trả về 0.0 hoặc một giá trị mặc định khác.
                return 0.0;
            }
        }

        public override string GetMaterial()
        {
            return necklace.GetMaterial();
        }

        public override string GetDescription()
        {
            return necklace.GetDescription();
        }

         public override double GetPrice()
        {
            return necklace.GetPrice();
        }
    }
}

