using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudio7
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public int PointValue { get; set; }

        public Question(string question)
        {
            QuestionText = question;
        }

        public void DisplayQuestion() 
        {
            Console.WriteLine(QuestionText);
        }

        public abstract void DisplayPossibleAnswers();
        public abstract int ScoreAnswer();
    }
}
