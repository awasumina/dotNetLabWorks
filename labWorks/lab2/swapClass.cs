using System;

namespace Lab2
{
    public class swapClass
    {
        public void swapNumber()
        {
            Console.WriteLine("2. Write a C# Sharp program to swap two numbers.");

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Original numbers: " + num1 + "and" + num2);

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Swapped numbers: " + num1 + "and" + num2);
        }
    }
}
