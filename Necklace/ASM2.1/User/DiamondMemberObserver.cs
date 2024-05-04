using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necklace.ASM2._1.User
{
    public class DiamondMemberObserver : IObserver
    {
        public double Update(double amountSpent)
        {
            if (amountSpent >= 15000000000) // 1500 million VND
            {
                Console.WriteLine("User is now a Diamond member. you get a discout 8%");
                return 0.08;
            }
            else
            return 1;
        }
    }
}
