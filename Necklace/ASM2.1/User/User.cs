using System;
using System.Collections.Generic;

namespace Necklace.ASM2._1.User
{
    public class User : IMembership
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _membershipLevel = "none";
        private double _discountRatio = 0.0;
        private double _totalAmountSpent = 0.0;

        public string MembershipLevel
        {
            get { return _membershipLevel; }
            private set
            {
                if (_membershipLevel != value)
                {
                    _membershipLevel = value;
                    Console.WriteLine($"User is now a {_membershipLevel} member. You get a discount of {DiscountRatio * 100}%");
                }
            }
        }

        public double DiscountRatio
        {
            get { return _discountRatio; }
            private set { _discountRatio = value; }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(double amountSpent)
        {
            double highestDiscount = 0;
            foreach (var observer in _observers)
            {
                double newDiscount = observer.Update(amountSpent);
                if (newDiscount != 1 && newDiscount > highestDiscount)
                {
                    highestDiscount = newDiscount;
                }
            }

            if (highestDiscount > 0 && highestDiscount != DiscountRatio)
            {
                DiscountRatio = highestDiscount;
                UpdateMembershipLevel();
            }
        }

        private void UpdateMembershipLevel()
        {
            if (DiscountRatio == 0.08)
            {
                MembershipLevel = "Diamond";
            }
            else if (DiscountRatio == 0.05)
            {
                MembershipLevel = "Gold";
            }
            else if (DiscountRatio == 0.02)
            {
                MembershipLevel = "Silver";
            }
            else
            {
                MembershipLevel = "None";
            }
        }

        public void AddAmountSpent(double amount)
        {
            _totalAmountSpent += amount;
            Notify(_totalAmountSpent);
        }
    }
}
