using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    // Strategy interface
    interface IDiscountStrategy
    {
        double ApplyDiscount(double amount);
    }

    // Concrete strategies
    class LowDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount * 0.9; // 10% discount
        }
    }

    class HighDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount * 0.8; // 20% discount
        }
    }

    class NoDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount; // No discount
        }
    }

    // Context class
    class ShoppingCart
    {
        private IDiscountStrategy? _discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double Checkout(double totalAmount)
        {
            if (_discountStrategy == null)
            {
                throw new InvalidOperationException("Discount strategy is not set");
            }

            // Apply discount using the selected strategy
            return _discountStrategy.ApplyDiscount(totalAmount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create shopping cart
            var cart = new ShoppingCart();

            // Simulate different customer scenarios
            Console.WriteLine("Scenario 1: Membership Card");
            cart.SetDiscountStrategy(new LowDiscountStrategy());
            Console.WriteLine("Total amount after discount: " + cart.Checkout(100)); // Expecting 90

            Console.WriteLine("\nScenario 2: Employee Card");
            cart.SetDiscountStrategy(new HighDiscountStrategy());
            Console.WriteLine("Total amount after discount: " + cart.Checkout(100)); // Expecting 80

            Console.WriteLine("\nScenario 3: No Card");
            cart.SetDiscountStrategy(new NoDiscountStrategy());
            Console.WriteLine("Total amount after discount: " + cart.Checkout(100)); // Expecting 100

        }
    }
}
