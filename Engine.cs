using static mathGame.Global;
using static mathGame.System;
namespace mathGame
{

    internal class Engine
    {

        public static void additionGame()
        {
            randomNumber r = new randomNumber();
            globalVars g = new() ;
            int value;
            int result;
            bool isrunning = true;
            g.Limit = pointSelection();
            while (isrunning)
            {
                while (g.Points != g.Limit)
                {
                    result = r.A + r.B;
                    value = result;
                    Console.WriteLine($"{r.A} + {r.B}?");
                    if (result == int.Parse(Console.ReadLine()))
                    {
                        g.Points++;
                        Console.Clear();
                        Console.WriteLine("+1 Point!\n\n");
                    }
                    else
                    {
                        Console.WriteLine("You Lost!");
                    }

                    if (result == value)
                    {
                        r = new randomNumber();
                    }
                }
                continueGame();
            }
        }
        public static void subtractionGame()
        {
            randomNumber r = new randomNumber();
            globalVars g = new();
            int value;
            int result;
            bool isrunning = true;
            g.Limit = pointSelection();
            while (isrunning)
            {
                while (g.Points != g.Limit)
                {
                    result = r.A - r.B;
                    value = result;
                    Console.WriteLine($"{r.A} - {r.B}?");
                    if (result == int.Parse(Console.ReadLine()))
                    {
                        g.Points++;
                        Console.Clear();
                        Console.WriteLine("+1 Point!\n\n");
                    }
                    else
                    {
                        Console.WriteLine("You Lost!");
                    }
                    if (result == value)
                    {
                        r = new randomNumber();
                    }
                }
                continueGame();
            }
        }
        public static void multiplicationGame()
        {
            randomNumber r = new randomNumber();
            globalVars g = new();
            Random rand = new Random();
            int value;
            int result;
            bool isrunning = true;
            g.Limit = pointSelection();
            while (isrunning)
            {
                while (g.Points != g.Limit)
                {
                    result = r.A * r.B;
                    value = result;
                    Console.WriteLine($"{r.A} * {r.B}?");
                    if (result == int.Parse(Console.ReadLine()))
                    {
                        g.Points++;
                        Console.Clear();
                        Console.WriteLine("+1 Point!\n\n");
                    }
                    else
                    {
                        Console.WriteLine("You Lost!");
                    }
                    if (result == value)
                    {
                        r = new randomNumber();
                    }
                }
                continueGame();
            }
        }
        public static void divisionGame()
        {
            randomNumber r = new randomNumber();
            globalVars g = new globalVars();
            int value;
            int result;
            bool isrunning = true;
            g.Limit = pointSelection();
            while (isrunning)
            {
                while (g.Points != g.Limit)
                {
                    while (r.A % r.B != 0)
                    {
                        r = new randomNumber();
                    }

                    Console.WriteLine("Reach 25 points!\n");
                    Console.WriteLine($"{r.A} / {r.B}?");
                    result = r.A / r.B;
                    value = result;
                    if (result == int.Parse(Console.ReadLine()))
                    {
                        g.Points++;
                        Console.Clear();
                        Console.WriteLine("+1 Point!\n\n");
                    }
                    else
                    {
                        Console.Clear();
                    }
                    if (result == value)
                    {
                        r = new randomNumber();
                    }
                }
                continueGame();
            }
        }
    }
}
