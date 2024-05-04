using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necklace.ASM2._1.User
{
    public class SilverMemberObserver : IObserver
    {
        public double Update(double amountSpent)
        {
            if (amountSpent >= 100000000) // 1000 million VND
            {
                Console.WriteLine("User is now a Silver member. You get a discout 2%");
                return 0.02;
            }
            else
            return 1;
        }
    }
}
