using System;

class FormattingNumbers
{
    /*
     Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them 
     in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in 
     hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should 
     be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the 
     decimal point, left aligned. 
     */
    static void Main(string[] args)
    {
        int numberA = -1;
        while (!(numberA >= 0 && numberA <= 500))
        {
            Console.WriteLine("Enter a number between 0 and 500.");
            numberA = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter a floating-point number.");
        double numberB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a floating-point number.");
        double numberC = double.Parse(Console.ReadLine());

        string hexA = Convert.ToString(numberA, 16).PadRight(10);
        string bits = Convert.ToString(numberA, 2).PadLeft(10, '0');
        string numB = numberB.ToString("F2").PadLeft(10);
        string numC = numberC.ToString("F3").PadRight(10);
        string intB = numberB.ToString().PadLeft(10);
        string intC = numberB.ToString().PadLeft(10);

        Console.WriteLine("|{0}|{1}|{2}|{3}|", hexA.ToUpper(), bits, numB, numC);
    }
}

