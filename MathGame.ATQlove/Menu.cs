namespace MathGame.ATQlove;

internal class Menu
{
    GameEngine engine = new();
    
    internal void ShowMenu(string name, DateTime date)
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
SD - Set Difficulty
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
                case "sd":
                    Utilities.SetDifficulty(); 
                    break;
                case "a":
                    engine.PlayGame(MathOperation.Addition, "Solve the following addition problems!");
                    break;
                case "s":
                    engine.PlayGame(MathOperation.Subtraction, "Solve the following subtraction problems!");
                    break;
                case "m":
                    engine.PlayGame(MathOperation.Multiplication, "Solve the following multiplication problems!");
                    break;
                case "d":
                    engine.PlayGame(MathOperation.Division, "Solve the following division problems!");
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
