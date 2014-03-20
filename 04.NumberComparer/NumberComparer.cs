using System;

class NumberComparer
{
    //Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if 
    //statements. 
    static void Main(string[] args)
    {
        decimal number = decimal.Parse(Console.ReadLine());
        decimal number2 = decimal.Parse(Console.ReadLine());
        bool isGreater = number > number2;
        Console.WriteLine(isGreater ? number : number2);
    }
}

