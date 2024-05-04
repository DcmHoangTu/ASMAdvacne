using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necklace.ASM2._1.User
{
    public class GoldMemberObserver : IObserver
    {
        public double Update(double amountSpent)
        {
            if (amountSpent >= 500000000) // 500 million VND
            {
                Console.WriteLine("User is now a Gold member.You get a discout 5%");
                return 0.05;
            }
            else
            return 1;
        }
    }
}
