using System;

class FibonacciNumbers
{
    //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single 
    //line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to 
    //use loops. 
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount N of Fibonacci numbers");
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;
        int nextNum = 0;
        int nextNum2 = 1;
        for (int i = 0; i < numberN; i++)
        {
            Console.Write(nextNum + " ");
            sum = nextNum + nextNum2;
            nextNum = nextNum2;
            nextNum2 = sum;
        }
    }
}

