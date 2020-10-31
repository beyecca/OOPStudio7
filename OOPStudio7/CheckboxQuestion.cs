using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudio7
{
    public class CheckboxQuestion : Question
    {
        private List<int> correctAnswers;
        private Dictionary<int, string> possibleAnswers;

        public CheckboxQuestion(string question, Dictionary<int, string> answers, List<int> correctKeys) : base(question)
        {
            correctAnswers = correctKeys;
            possibleAnswers = answers;
            PointValue = correctAnswers.Count;
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
            Console.WriteLine("Multiple answers could be correct for this question. \n Please enter the numbers that correspond with your, **separated by commas**");
            string userInput = Console.ReadLine();
            List<int> userAnswers = ParseInput(userInput);

            int totalScore = 0;

            foreach (var answer in userAnswers) 
            {
                if (correctAnswers.Contains(answer)) 
                {
                    totalScore++;
                }
            }

            return totalScore;
        }

        private List<int> ParseInput(string userInput)
        { 
            var userAnswersAsStrings = userInput.Split(",").ToList();
            var userAnswersAsInts = userAnswersAsStrings.Select(answer => int.Parse(answer)).ToList();
            return userAnswersAsInts;
        }
    }
}
