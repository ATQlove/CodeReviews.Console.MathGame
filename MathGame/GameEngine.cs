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

        for(int i = 0; i<5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

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
                Console.WriteLine($"Game over. Your final score is {score}. Press any Key to go back to the menu.");
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

        for (int i = 0; i<5;i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber= random.Next(1, 9);
            secondNumber= random.Next(1, 9);

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

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }

        Utilities.AddToHistory(score, GameType.Addition);
    }

    internal void Multiplication(string message)
    {
        Random random = new Random();
        int score = 0;

        int firstNumber;
        int secondNumber;

        for(int i = 0; i<5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            firstNumber = random.Next(1, 9);
            secondNumber = random.Next(1, 9);

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

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }
    }

    internal void Division(string message)
    {
        int score = 0;

        for(int i = 0; i<5;i++)
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

            if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
        }

        Utilities.AddToHistory(score, GameType.Division);

    }
}
