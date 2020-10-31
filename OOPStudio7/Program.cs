using System;
using System.Collections.Generic;

namespace OOPStudio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz!");

            var quiz = new List<Question>
            {
                new TrueFalseQuestion("Do cats have 4 legs?", true),
                new CheckboxQuestion("Which flavors are in Reese's candy?", new Dictionary<int, string> { { 1, "chocolate" }, {2, "hazelnut" }, {3, "peanut butter" } }, new List<int> { 1,3 }),
                new MultipleChoiceQuestion("When did Hocus Pocus come out?", 2, new Dictionary<int, string>{ {1, "1990" }, {2, "1993" }, {3, "1996" } })
            };

            var totalScore = 0;
            var totalPossibleScore = 0;

            foreach (var question in quiz) 
            {
                question.DisplayQuestion();
                question.DisplayPossibleAnswers();

                var score = question.ScoreAnswer();

                totalScore += score;
                totalPossibleScore += question.PointValue;
            }

            Console.WriteLine($"Your final score was: {totalScore}/{totalPossibleScore}");
            Console.WriteLine("Thank you for Playing!");
        }
    }
}
