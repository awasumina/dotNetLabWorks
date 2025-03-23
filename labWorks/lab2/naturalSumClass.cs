using System;

namespace Lab2
{
    public class NaturalSumClass
    {
        public void CalculateSum()
        {
            Console.WriteLine("5. Write a C# Sharp program to display the sum of n natural numbers.");

            Console.Write("Enter a positive integer (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Please enter a positive integer greater than zero.");
                return;
            }

            int sum = n * (n + 1) / 2;

            Console.WriteLine("The sum of the first natural numbers is: " + sum );
        }
    }
}
