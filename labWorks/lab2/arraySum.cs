using System;

namespace Lab2
{
    public class ArraySum
    {
        public void CalculateSum()
        {
            Console.WriteLine("7. Write a C# Sharp program to create an integer array and print the sum of array elements.");

            int[] arr = { 10, 20, 30, 40, 50 };

            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }

            Console.WriteLine($"The sum of the array elements is: " +sum);
        }
    }
}
