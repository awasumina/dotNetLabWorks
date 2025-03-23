using System;

namespace Lab2
{
    public class primeClass
    {
        public void checkPrime()
        {
            Console.WriteLine("9. Write a program to check if input number is a prime number");
            Console.Write("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < 2)
            {
                Console.WriteLine("Not a prime number");
                return;
            }

            for (int i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine("Not a prime number");
                    return; // It will Stop execution if not prime so that it will not print "Is a prime number" when it is out of for loop
                }
            }

            Console.WriteLine("Is a prime number");
        }
    }
}
