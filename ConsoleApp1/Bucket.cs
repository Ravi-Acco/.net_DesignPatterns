using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Context class
    class Bucket
    {
        private DiscountStrategy? chooseStrategy;

        public void SetPaymentMethod(DiscountStrategy discountStrategy)
        {
            chooseStrategy = discountStrategy;
        }

        public double Checkout(double totalAmount)
        {
            if (chooseStrategy == null)
            {
                throw new InvalidOperationException("Choose the discount strategy first");
            }

            // Apply discount using the selected strategy
            return chooseStrategy.ApplyDiscount(totalAmount);
        }
    }
}
