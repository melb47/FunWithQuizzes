using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class TrueFalse : Question
    {
        private bool CorrectAnswer { get; }
        public TrueFalse(string text, bool correctAnswer) : base(text)
        {
            CorrectAnswer = correctAnswer;
        }
        public override void ShowQuestionAndAnswers()
        {
            Console.WriteLine($"TRUE or FALSE: \n{Text}");
        }
        public override int GiveScore()
        {
            bool response = bool.Parse(Console.ReadLine());
            if (response == CorrectAnswer)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
