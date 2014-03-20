using System;

class QuadraticEquation
{
    //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its 
    //real roots). 
    static void Main(string[] args)
    {
        //TODO Thread
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        
        if (numberA != 0)
        {
            FindRootQuadratic(numberA, numberB, numberC);
        }
        else
        {
            FindRootLinear(numberB, numberC);
        }
    }

    private static void FindRootLinear(double numberB, double numberC)
    {
        double numberX;
        Console.WriteLine("Not a quadratic but linear equation");
        if (numberB == 0)
        {
            if (numberC == 0)
            {
                Console.WriteLine("Every number is root");
            }
            else
            {
                Console.WriteLine("No solution");
            }
        }
        else
        {
            numberX = -numberC / numberB;
            Console.WriteLine("X = " + numberX);
        }
    }

    private static void FindRootQuadratic(double numberA, double numberB, double numberC )
    {
        double numberX;
        double numberX2;
        double discriminant = numberB * numberB - 4 * numberA * numberC;
        if (discriminant < 0)
        {
            Console.WriteLine("No solution");
        }
        else if (discriminant == 0)
        {
            numberX = -numberB / (2 * numberA);
            Console.WriteLine("1 real root. X = " + numberX);
        }
        else
        {
            numberX = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
            numberX2 = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA);
            Console.WriteLine("2 real roots. X 1 = {0}. X 2 = {1}", numberX, numberX2);
        }
    }
}

