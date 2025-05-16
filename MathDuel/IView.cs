using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathDuel
{
    public class IView
    {
        public void Display(string question, int score)
        {
            Console.Clear();
            Console.WriteLine("=== Math Duel ===");
            Console.WriteLine("Answer the math problems correctly!");
            Console.WriteLine("You can make up to 3 mistakes.");
            Console.WriteLine();

            Console.Write("Question: " + question + " ");
            string input = Console.ReadLine();
            int playerAnswer = int.Parse(input);
        }

        public void DisplayCorrectAnswer(int correctAnswer)
        {
            Console.WriteLine("Correct!\n");
        }
        public void DisplayWrongAnswer(int correctAnswer)
        {
            Console.WriteLine($"Wrong! The correct answer was {correctAnswer}.\n");
        }
        public void DisplayGameOver(int score)
        {
            Console.WriteLine($"Game over! Your final score is: {score}");
        }
    }
}