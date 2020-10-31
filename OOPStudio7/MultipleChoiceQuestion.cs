using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOPStudio7
{
    public class MultipleChoiceQuestion : Question
    {
        private int correctAnswer;
        private Dictionary<int, string> possibleAnswers;

        public MultipleChoiceQuestion(string question, int correctKey, Dictionary<int, string> answerKey) : base(question)
        {
            correctAnswer = correctKey;
            possibleAnswers = answerKey;
            PointValue = 1;
        }

        public override void DisplayPossibleAnswers()
        {
            foreach (var answer in possibleAnswers) 
            {
                Console.WriteLine($"{answer.Key} - {answer.Value}");
            }
            Console.WriteLine();
        }

        public override int ScoreAnswer()
        {
            Console.WriteLine("What is your answer? Enter the number that corresponds with your answer.");
            string userInput = Console.ReadLine();
            int userAnswer = ParseInput(userInput);

            if (userAnswer == correctAnswer)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        private int ParseInput(string input) 
        {
            return int.Parse(input);
        }
    }
}
