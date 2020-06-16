using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class Quiz
    {
        public int NumberCorrect { get; set; }

        public List<Question> QuizQuestions { get; set; }

        public Quiz(List<Question> quizQuestions)
        {
            QuizQuestions = quizQuestions;
            NumberCorrect = 0;
        }
        public void AddQuestion(Question newQuestion)
        {
            QuizQuestions.Add(newQuestion);
        }
        public void RunQuiz()
        {
            foreach(Question q in QuizQuestions)
            {
                q.ShowQuestionAndAnswers();
                int points = q.GiveScore();
                NumberCorrect += points;
            }
        }
        public void GradeQuiz()
        {
            int total = QuizQuestions.Count;
            int correct = NumberCorrect;
            int percent = correct / total * 100;
            Console.WriteLine($"You finished. You got {NumberCorrect} correct out of {QuizQuestions.Count}\nYour score is {percent}%");
        }
    }
}
