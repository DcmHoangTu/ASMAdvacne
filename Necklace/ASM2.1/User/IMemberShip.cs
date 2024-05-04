using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necklace.ASM2._1.User
{
    public interface IMembership
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(double amountSpent);
    }
}
