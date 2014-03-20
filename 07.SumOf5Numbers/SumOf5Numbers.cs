using System;

class SumOf5Numbers
{
    //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
    static void Main(string[] args)
    {
        string numbers = Console.ReadLine();
        string[] splitNumbers = numbers.Split(new Char[]{' '});
        
        decimal sum = 0;
        for (int i = 0; i < splitNumbers.Length; i++)
        {
            decimal number;
            if (Decimal.TryParse(splitNumbers[i], out number))
            {
                sum += number;
            }
            else
            {
               sum += 0;
            }
        }
        Console.WriteLine("Sum: " + sum);
    }
}

