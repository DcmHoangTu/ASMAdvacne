using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necklace.ASM2._1.User
{
    public interface IObserver
    {
        double Update(double amountSpent){
            return 1;
        }
    }
}
