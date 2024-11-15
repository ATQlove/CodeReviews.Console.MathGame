using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathGame.ATQlove.Model;

namespace MathGame.ATQlove;

public enum MathOperation
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal class GameEngine
{
    internal void PlayGame(MathOperation operation, string message)
    {
        Random random = new Random();
        int score = 0;
        int firstNumber;
        int secondNumber;

        DateTime startTime = DateTime.Now;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            if (operation == MathOperation.Division)
            {
                int[] divisionNumbers = Utilities.GetDivisionNumbers();
                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];
            }
            else
            {
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
            }

            string question = GenerateQuestion(operation, firstNumber, secondNumber);
            Console.WriteLine(question);

            string res = Console.ReadLine();
            res = Utilities.ValidateResult(res);

            if (CheckAnswer(operation, firstNumber, secondNumber, int.Parse(res)))
            {
                Console.WriteLine("Correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect >^< ! Type any key for the next question");
                Console.ReadLine();
            }

            if (i == 4)
            {
                DateTime endTime = DateTime.Now;
                TimeSpan duration = endTime - startTime;
                Console.WriteLine($"Game over. You spent {duration.TotalSeconds} seconds to finish those questions.\nYour final score is {score}. Press any key to go back to the menu.");
                Console.ReadLine();
            }
        }

        Utilities.AddToHistory(score, (GameType)operation);
    }

    private string GenerateQuestion(MathOperation operation, int firstNumber, int secondNumber)
    {
        return operation switch
        {
            MathOperation.Addition => $"{firstNumber} + {secondNumber}",
            MathOperation.Subtraction => $"{firstNumber} - {secondNumber}",
            MathOperation.Multiplication => $"{firstNumber} * {secondNumber}",
            MathOperation.Division => $"{firstNumber} / {secondNumber}",
            _ => throw new InvalidOperationException("Unknown math operation")
        };
    }

    private bool CheckAnswer(MathOperation operation, int firstNumber, int secondNumber, int userAnswer)
    {
        return operation switch
        {
            MathOperation.Addition => userAnswer == firstNumber + secondNumber,
            MathOperation.Subtraction => userAnswer == firstNumber - secondNumber,
            MathOperation.Multiplication => userAnswer == firstNumber * secondNumber,
            MathOperation.Division => userAnswer == firstNumber / secondNumber,
            _ => throw new InvalidOperationException("Unknown math operation")
        };
    }
}
