using System;

namespace Lab2
{
    public class FactorialCalculator
    {
        public void CalculateFactorial()
        {
            Console.WriteLine("8. Write a C# Sharp program to calculate the factorial of a given number.");

            Console.Write("Enter a number to calculate its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of {number} is: " + factorial);
        }
    }
}
