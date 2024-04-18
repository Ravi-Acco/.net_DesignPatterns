using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Concrete strategy
    internal class MembershipCard : DiscountStrategy
    {
        public override double ApplyDiscount(double amount)
        {
            return amount * 0.9; // 10% discount
        }
    }
}
