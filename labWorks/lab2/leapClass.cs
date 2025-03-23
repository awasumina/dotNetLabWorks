using System;

namespace Lab2
{
    public class LeapClass
    {
        public void findLeapYear()
        {
            Console.WriteLine("6. Check whether a given year is a leap year or not. ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 4 == 0)
            {
                if (N % 100 == 0)
                {
                    if (N % 400 == 0)
                    {
                        Console.WriteLine("It is leap year");
                    }
                    else
                    {
                        Console.WriteLine("Is is not leapYear");
                    }
                }
                else
                {
                    Console.WriteLine("Is is  leapYear");
                }
            }
            else
            {
                Console.WriteLine("It is not Leapyear");
            }


        }
    }
}



