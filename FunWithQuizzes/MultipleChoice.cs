using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class MultipleChoice : Question
    {
        private List<string> Answers { get; }
        private int CorrectAnswer { get; }
        public MultipleChoice(string text, List<string> answers, int correctAnswer) : base(text)
        {
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public override void ShowQuestionAndAnswers()
        {
            Console.WriteLine($"Choose the ONE correct answer:\n{Text}");
            foreach (string ans in Answers)
            {
                Console.WriteLine($"{Answers.IndexOf(ans)}: {ans}");
            }
        }
        public override int GiveScore()
        {
            int response = int.Parse(Console.ReadLine());
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
