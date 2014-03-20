using System;

class SumOfNNumbers
{
    //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that 
    //you may need to use a for-loop. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter amount of numbers N");
        int numberN = int.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 0; i < numberN; i++)
        {
            Console.Write("{0}: ", i + 1);
            decimal num = decimal.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("Sum: " + sum);
    }
}

