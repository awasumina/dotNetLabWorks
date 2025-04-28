using dotnetClassWorks;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        MathOperations mathObj = new MathOperations();
        int addIntValue = mathObj.Add(2, 3);
        double addDoubleValue = mathObj.Add(2.22, 3.33);

        Console.WriteLine("Int add" + addIntValue);
        Console.WriteLine("Double add" + addDoubleValue);


        int multipleIntValue = mathObj.Multiply(2, 3);
        double multipleDoubleValue = mathObj.Multiply(2.222, 3.33);
        Console.WriteLine("Int Multiple" + multipleIntValue);
        Console.WriteLine("Double Multiple" + multipleDoubleValue);



        //for multipleInheritance.cs
        multipleInheritance obj2 = new multipleInheritance();
        double addInheritance = obj2.Add(2.2, 3.3);
        Console.WriteLine("Multiple inheritance add" + addInheritance);


        //for palindrome
        Console.WriteLine("Enter a word to check palindrome:");
        string inputstr = Console.ReadLine();
        Palindrome palin = new Palindrome();
        bool ispalin = palin.checkpalin(inputstr);
        if (ispalin)
        {
            Console.WriteLine("The word " + inputstr + " is palindrome.");
        }
        else
        {
            Console.WriteLine("The word " + inputstr + " is not palindrome.");
        }

    }

}