using System;

namespace Lab2
{
    public class EvenOddChecker
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("4. Write a C# Sharp program to check whether a number is even or odd.");

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " is an even number.");
            else
                Console.WriteLine(num + " is an odd number.");
        }
    }
}
