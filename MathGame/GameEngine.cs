using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathGame.Model;

namespace MathGame;

internal class GameEngine
{
    internal void Addition(string message)
    {
        Random random = new Random();
        int score = 0;

        int firstNumber;
        int secondNumber;

        DateTime startTime = DateTime.Now;                

        for (int i = 0; i<5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            if(Utilities.difficulty == 1)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
            }
            else if(Utilities.difficulty == 2)
            {
                firstNumber = random.Next(11, 49);
                secondNumber = random.Next(11, 49);
            }
            else
            {
                firstNumber = random.Next(11,99);
                secondNumber=random.Next(11,99);
            }

            Console.WriteLine($"{firstNumber} + {secondNumber}");

            string res = Console.ReadLine();
            res = Utilities.ValidateResult(res);

            if(int.Parse(res) == firstNumber + secondNumber)
            {
                Console.WriteLine("Correct! Type any key for the next quesiton");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect >^< ! Type any key for the next quesiton");
                Console.ReadLine();
            }

            if(i == 4)
            {
                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;
                Console.WriteLine($"Game over. You spend {duration.TotalSeconds} senconds to finish those questions.\n Your final score is {score}. Press any Key to go back to the menu.");
                Console.ReadLine();
            }
        }

        Utilities.AddToHistory(score, GameType.Addition);
    }

    internal void Subtraction(string message)
    {
        Random random = new Random();
        int score = 0;

        int firstNumber;
        int secondNumber;

        DateTime startTime = DateTime.Now;

        for (int i = 0; i<5;i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            if (Utilities.difficulty == 1)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
            }
            else if (Utilities.difficulty == 2)
            {
                firstNumber = random.Next(11, 49);
                secondNumber = random.Next(11, 49);
            }
            else
            {
                firstNumber = random.Next(11, 99);
                secondNumber = random.Next(11, 99);
            }

            Console.WriteLine($"{firstNumber} - {secondNumber}");

            var res = Console.ReadLine();
            res = Utilities.ValidateResult(res);

            if(int.Parse(res)==firstNumber - secondNumber)
            {
                Console.WriteLine("Correct! Type any key for the next question");
                score++; 
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect >^< ! Type any key for the next quesiton");
                Console.ReadLine();
            }

            if (i == 4)
            {
                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;
                Console.WriteLine($"Game over. You spend {duration.TotalSeconds} senconds to finish those questions.\n Your final score is {score}. Press any Key to go back to the menu.");
                Console.ReadLine();
            }
        }

        Utilities.AddToHistory(score, GameType.Addition);
    }

    internal void Multiplication(string message)
    {
        Random random = new Random();
        int score = 0;

        int firstNumber;
        int secondNumber;

        DateTime startTime = DateTime.Now;

        for (int i = 0; i<5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            if (Utilities.difficulty == 1)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
            }
            else if (Utilities.difficulty == 2)
            {
                firstNumber = random.Next(11, 49);
                secondNumber = random.Next(11, 49);
            }
            else
            {
                firstNumber = random.Next(11, 99);
                secondNumber = random.Next(11, 99);
            }

            Console.WriteLine($"{firstNumber} * {secondNumber}");

            var res = Console.ReadLine();
            res = Utilities.ValidateResult(res);

            if( int.Parse(res)==firstNumber * secondNumber) 
            { 
                Console.WriteLine("Correct! Type any key for the next question");
                score++; 
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect >^< ! Type any key for the next quesiton");
                Console.ReadLine();
            }

            if (i == 4)
            {
                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;
                Console.WriteLine($"Game over. You spend {duration.TotalSeconds} senconds to finish those questions.\n Your final score is {score}. Press any Key to go back to the menu.");
                Console.ReadLine();
            }
        }
    }

    internal void Division(string message)
    {
        int score = 0;

        DateTime startTime = DateTime.Now;

        for (int i = 0; i<5;i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            int[] divisionNumber = Utilities.GetDivisionNumbers();
            int firstNumber = divisionNumber[0];
            int secondNumber = divisionNumber[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var res = Console.ReadLine() ;
            res = Utilities.ValidateResult(res);

            if(int.Parse(res)==firstNumber / secondNumber)
            {
                Console.WriteLine("Correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect >^< ! Type any key for the next quesiton");
                Console.ReadLine();
            }

            if (i == 4)
            {
                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;
                Console.WriteLine($"Game over. You spend {duration.TotalSeconds} senconds to finish those questions.\n Your final score is {score}. Press any Key to go back to the menu.");
                Console.ReadLine();
            }
        }

        Utilities.AddToHistory(score, GameType.Division);

    }
}
