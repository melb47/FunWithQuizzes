using System;
using System.Collections.Generic;

namespace FunWithQuizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz myQuiz = new Quiz(new List<Question>());
            List<string> mc1PossAns = new List<string> { "Paris", "London", "Washington D.C.", "Tokyo" };
            MultipleChoice multipleChoice1 = new MultipleChoice("What is the capital of Japan?", mc1PossAns, 3);

            List<string> check1PossAns = new List<string> { "Garfield", "Odie", "Pluto", "Goofy", "Mickey" };
            Checkbox checkbox1 = new Checkbox("Which ones are cartoon dogs?",check1PossAns, 123);

            TrueFalse trueFalse1 = new TrueFalse("Disney owns the rights to the Simpsons.", true);

            List<string> mc2PossAns = new List<string> { "Potatoes", "Wheat", "Corn", "Agave" };
            MultipleChoice multipleChoice2 = new MultipleChoice("What is Vodka made from?", mc2PossAns, 0);

            List<string> check2PossAns = new List<string> { "3 miles", "6 miles", "13 miles", "26 miles" };
            Checkbox checkbox2 = new Checkbox("A half marathon is equivalent to approximately how many miles?", check2PossAns, 2);

            TrueFalse trueFalse2 = new TrueFalse("Hawaii observes Daylight Savings Time", false);

            myQuiz.AddQuestion(multipleChoice1);
            myQuiz.AddQuestion(checkbox1);
            myQuiz.AddQuestion(trueFalse1);
            myQuiz.AddQuestion(multipleChoice2);
            myQuiz.AddQuestion(checkbox2);
            myQuiz.AddQuestion(trueFalse2);

            myQuiz.RunQuiz();
            myQuiz.GradeQuiz();
        }
    }
}
