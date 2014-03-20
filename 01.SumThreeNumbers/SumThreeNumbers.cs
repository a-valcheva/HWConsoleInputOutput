using System;
using System.Threading;
using System.Globalization;

class SumThreeNumbers
{
/*   
Write a program that reads 3 integer numbers from the console and prints their sum. Examples:
a	b	c	sum
3	4	11	18
-2	0	3	1
5.5	4.5	20.1	30.1
*/
    //The last example is not for an integer!
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
   
        double[] numbers = new double[3];
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a number.");
            double number = double.Parse(Console.ReadLine());
            numbers[i] = number;
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}

