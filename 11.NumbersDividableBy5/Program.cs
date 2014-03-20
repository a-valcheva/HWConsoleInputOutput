using System;

class Program
{
    //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the 
    //reminder of the division by 5 is 0. 
    static void Main(string[] args)
    {
        Console.WriteLine("Start number");
        int startNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("End number");
        int endNumber = int.Parse(Console.ReadLine());
        int pCounter = 0;
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                pCounter++;
            }
        }
        Console.WriteLine(pCounter);
    }
}

