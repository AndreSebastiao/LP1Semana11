using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathDuel
{
    public class Controller : IView
    {
        Random rand = new Random();
        int score = 0;
        int wrongAnswers = 0;
        

        while (wrongAnswers < 3)
        {
            int a = rand.Next(1, 11);     // 1 to 10
            int b = rand.Next(1, 11);
            int operation = rand.Next(3); // 0: +, 1: -, 2: *

            int correctAnswer;
            string question;

            if (operation == 0)
            {
                correctAnswer = a + b;
                question = $"{a} + {b} = ?";
            }
            else if (operation == 1)
            {
                correctAnswer = a - b;
                question = $"{a} - {b} = ?";
            }
            else
            {
                correctAnswer = a * b;
                question = $"{a} * {b} = ?";
            }

            if (playerAnswer == correctAnswer)
            {
                DisplayCorrectAnswer();
                score++;
            }
            else
            {
                DisplayWrongAnswer();
                wrongAnswers++;
            }
        }
    }
}