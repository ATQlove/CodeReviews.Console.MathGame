using MathGame.ATQlove.Model;

namespace MathGame.ATQlove;

internal class Utilities
{
    internal static int difficulty = 1;

    internal static void SetDifficulty()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine($@"
Please input the difficulty you want to set:
1 - Easy
2 - Medium
3 - Hard");

        var setConfig = Console.ReadLine();
        
        while (true)
        {
            setConfig = ValidateResult(setConfig);
            if (int.Parse(setConfig) == 1)
            {
                difficulty = 1;
                Console.WriteLine("Successfully set difficulty to Easy!");
                break;
            }
            else if (int.Parse(setConfig) == 2)
            {
                difficulty = 2;
                Console.WriteLine("Successfully set difficulty to Medium!");
                break;
            }
            else if (int.Parse(setConfig) == 3)
            {
                difficulty = 3;
                Console.WriteLine("Successfully set difficulty to Hard!");
                break;
            }
            else
            {
                Console.WriteLine("You must type 1, 2 or 3. Try again:");
                setConfig = Console.ReadLine();
            }      
        }
        Console.WriteLine("---------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }

    internal static List<Game> games = new List<Game>
    {
        // Fake history
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
    };

    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType
        });
    }

    internal static string ValidateResult(string? result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try agin:");
            result = Console.ReadLine();
        }
        return result;
    }

    internal static string GetName()
    {
        Console.WriteLine("Please type your name:");
        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name can't be empty");
            name = Console.ReadLine();
        }

        return name;
    }

    internal static int[] GetDivisionNumbers() { 
        var random = new Random();
        int firstNumber;
        int secondNumber;

        do
        {
            if (difficulty == 1)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
            }
            else if (difficulty == 2)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }
            else
            {
                firstNumber = random.Next(1, 999);
                secondNumber = random.Next(1, 999);
            }
        } while (firstNumber % secondNumber != 0);

        var res = new int[2];

        res[0] = firstNumber;
        res[1] = secondNumber;

        return res;    
    }

    internal static void PrintHistory()
    {
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("---------------------------");
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
        }
        Console.WriteLine("---------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }
}
