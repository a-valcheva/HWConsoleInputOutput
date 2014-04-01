using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace _12.FallingRocksV2
{
    /*
     Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left 
     and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid 
     a crash.
     Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a 
     constant game speed by Thread.Sleep(150).
     Implement collision detection and scoring system.
     */
    public struct Rock
    {
        public char[] Type { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public ConsoleColor Color { get; set; }
        public int ScorePoints { get; set; }
    }

    class FallingRocks
    {
        static int playFieldWidth = 55;
        static Random randomGenerator = new Random();

        private static void SetGameField()
        {
            Console.WindowHeight = 30;
            Console.BufferHeight = 30;
            Console.WindowWidth = 70;
            Console.BufferWidth = 70;
        }

        private static Rock User()
        {
            Rock user = new Rock();
            user.Type = new char[] { '(', '0', ')' };
            user.Row = Console.BufferHeight - 1;
            user.Column = playFieldWidth / 2;
            user.Color = ConsoleColor.Gray;
            user.ScorePoints = 100;
            return user;
        }

        private static Rock RockGenerator()
        {
            Rock newRock = new Rock();
            ConsoleColor[] newColor = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue };
            char[] newType = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
            newRock.Column = randomGenerator.Next(0, playFieldWidth);
            newRock.Row = 0;
            int typeChoice = randomGenerator.Next(0, newType.Length);
            //int newRockLenth = randomGenerator.Next(0, 3);
            newRock.Type = new char[1];
            for (int i = 0; i < newRock.Type.Length; i++)
            {
                newRock.Type[i] = newType[typeChoice];
            }
            int colorChoice = randomGenerator.Next(0, newColor.Length);
            newRock.Color = newColor[colorChoice];
            return newRock;
        }

        private static void PrintCurrentRock(Rock rock)
        {
            Console.SetCursorPosition(rock.Column, rock.Row);
            Console.ForegroundColor = rock.Color;
            Console.Write(rock.Type);
        }

        static void PrintStringOnPosition(int column, int row, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(column, row);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main(string[] args)
        {
            SetGameField();
            Rock user = User();
            List<Rock> rocks = new List<Rock>();
            while (true)
            {
                rocks.Add(RockGenerator());
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressed = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressed.Key == ConsoleKey.LeftArrow)
                    {
                        if (user.Column - 1 >= 0)
                        {
                            user.Column = user.Column - 1;
                        }
                    }
                    else if (pressed.Key == ConsoleKey.RightArrow)
                    {
                        if (user.Column + 1 < playFieldWidth)
                        {
                            user.Column = user.Column + 1;
                        }
                    }
                }
                List<Rock> newRocks = new List<Rock>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    Rock oldRock = rocks[i];
                    Rock newRock = new Rock();
                    newRock.Column = oldRock.Column;
                    newRock.Row = oldRock.Row + 1;
                    newRock.Type = oldRock.Type;
                    newRock.Color = oldRock.Color;

                    if (newRock.Row < Console.WindowHeight)
                    {
                        newRocks.Add(newRock);
                    }

                    if (newRock.Row == user.Row)
                    {
                        if (newRock.Column >= user.Column && newRock.Column <= user.Column + user.Type.Length)
                        {
                            user.ScorePoints--;
                        }
                    }
                }
                rocks = newRocks;
                Console.Clear();

                foreach (var rock in rocks)
                {
                    PrintCurrentRock(rock);
                }
                PrintCurrentRock(user);
                PrintStringOnPosition(57, 4, "Score: " + user.ScorePoints, ConsoleColor.White);
                Thread.Sleep(150);
            }
        }
    }
}
