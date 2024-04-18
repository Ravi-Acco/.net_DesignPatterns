using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create bucket or shopping cart
            var bucket = new Bucket();

            // Simulate different customer scenarios
            Console.WriteLine("Simulating different strategies on an amount of 100\n");


            Console.WriteLine("Case 1: Using Membership Card");
            bucket.SetPaymentMethod(new MembershipCard());
            Console.WriteLine("Total amount after discount: " + bucket.Checkout(100)); // Expecting 90

            Console.WriteLine("\nCase 2: USing Employee Card");
            bucket.SetPaymentMethod(new EmployeeCard());
            Console.WriteLine("Total amount after discount: " + bucket.Checkout(100)); // Expecting 80

            Console.WriteLine("\nCase 3: Using No Card");
            bucket.SetPaymentMethod(new NoCard());
            Console.WriteLine("Total amount after discount: " + bucket.Checkout(100)); // Expecting 100

        }
    }
}
