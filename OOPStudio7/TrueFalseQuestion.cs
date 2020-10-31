using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace OOPStudio7
{
    public class TrueFalseQuestion : Question
    {
        private bool correctAnswer;

        public TrueFalseQuestion(string question, bool answer) : base(question)
        {
            correctAnswer = answer;
            PointValue = 1;
        }

        public override void DisplayPossibleAnswers()
        {
            Console.WriteLine("true or false");
        }

        public override int ScoreAnswer()
        {
            Console.WriteLine("What is your answer?");
            string userInput = Console.ReadLine();
            bool userAnswer = ParseInput(userInput);

            if (userAnswer == correctAnswer)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        private bool ParseInput(string input) 
        {
            if (input.ToLower() == "true")
            {
                return true;
            }
            else if (input.ToLower() == "false")
            {
                return false;
            }
            else 
            {
                throw new Exception("Invalid user input, please enter true or false!");
            }
        }
    }
}
