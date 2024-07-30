using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mathGame.Global;
using static mathGame.Engine;

namespace mathGame
{
    internal class System
    {
        public static int pointSelection()
        {
            Console.WriteLine("Choose point limit! (one point = one game)\n");
            int pointLimit = int.Parse(Console.ReadLine());
            Console.Clear();
            return pointLimit;
        }
        public static void continueGame()
        {
            globalVars g = new globalVars();
            string read;
            if (g.Points == g.Limit)
            {
                Console.Clear();
            }
            Console.WriteLine("You Won!\nWould you like to continue the current game?\nY/N");
            read = Console.ReadLine();
            string input = read.ToUpper();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be null or empty!");
            }
            else if (input == "Y")
            {
                Console.Clear();
                g.Limit = null;
                if (gameSelection.gameSelected ==1)
                {
                    additionGame();
                }else if(gameSelection.gameSelected == 2)
                {
                    subtractionGame();
                }
                else if (gameSelection.gameSelected == 3)
                {
                    multiplicationGame();
                }
                else if (gameSelection.gameSelected == 4)
                {
                    divisionGame();
                }
            }
            else if (input == "N")
            {
                GameSelection();
            }
        }
        public static void GameSelection()
        {
            globalVars g = new globalVars();
            bool flag = true;
            Console.Clear();
            Console.WriteLine("You've Chosen Games!");
            Console.Clear();
            Console.WriteLine("Choose a game!");
            Console.WriteLine("[1]Addition\n[2]Subtraction\n[3]Multiplication\n[4]Division\n[5]Back to main menu");
            while (flag)
            {
                g.Input = Console.ReadLine();
                if (string.IsNullOrEmpty(g.Input))
                {
                    Console.WriteLine("Input cannot be null or empty!");
                    continue;
                }
                else
                {
                    if ("1" == g.Input)
                    {
                        Console.Clear();
                        gameSelection.gameSelected = 1;
                        additionGame();
                    }
                    else if ("2" == g.Input)
                    {
                        Console.Clear();
                        gameSelection.gameSelected = 2;
                        subtractionGame();
                    }
                    else if ("3" == g.Input)
                    {
                        Console.Clear();
                        gameSelection.gameSelected = 3;
                        multiplicationGame();
                    }
                    else if ("4" == g.Input)
                    {
                        Console.Clear();
                        gameSelection.gameSelected = 4;
                        divisionGame();
                    }
                    else if ("5" == g.Input)
                    {
                        Console.Clear();
                        mainMenu();
                    }
                }
            }
        }
        public static void mainMenu()
        {
            bool flag = true;
            string input;
            Console.WriteLine("Welcome!");
            Console.WriteLine("Choose an option!:\n[1]Games\n[2]Game History\n[3]Exit\n");

            while (flag)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be null or empty!");
                    continue;
                }
                else
                {
                    if (input == "1")
                    {
                        GameSelection();
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("You've Chosen Game History!");
                        Console.WriteLine("WORK IN PROGRESS\nWORK IN PROGRESS\nWORK IN PROGRESS\nWORK IN PROGRESS\n");
                    }
                    else if (input == "3")
                    {
                        flag = false;
                    }
                }
            }
        }
    }
}
