using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame;

internal class Menu
{
    GameEngine engine = new();
    
    internal void showMenu(string name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine($"Hello {name}. It's {date}. This is your math's game.");
        Console.WriteLine("Type any key to show menu");
        Console.ReadLine();
        Console.WriteLine("\n");

        bool isGameOn = true;

        do
        {
            Console.Clear() ;
            Console.WriteLine($@"
What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
            Console.WriteLine("---------------------------------------------------------------------");

            var gameSelected = Console.ReadLine();

            switch (gameSelected.Trim().ToLower())
            {
                case "v":
                    Utilities.PrintHistory();
                    break;
                case "a":
                    engine.Addition("Addition game");
                    break;
                case "s":
                    engine.Subtraction("Subtraction game");
                    break;
                case "m":
                    engine.Multiplication("Multiplication game");
                    break;
                case "d":
                    engine.Division("Division game");
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        } while (isGameOn);
    }
}
