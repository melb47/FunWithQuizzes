using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public abstract class Question
    {
        public string Text { get; }

        public bool CorrectResponse { get; set; }

        public Question(string text)
        {
            Text = text;
        }


        public abstract void ShowQuestionAndAnswers();

        public abstract int GiveScore();
    }
}
