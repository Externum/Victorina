using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string RightAnswer { get; set; }
        private string[] wrongAnswers = new string[3];

        public Question(string questionText, string rightAnswer, string wrongAnswerOne, string wrongAnswerTwo, string wrongAnswerThree)
        {
            QuestionText = questionText;
            RightAnswer = rightAnswer;
            FillWrongAnswers(wrongAnswerOne, wrongAnswerTwo, wrongAnswerThree);
        }

        public void FillWrongAnswers(string wrongOne, string wrongTwo, string wrongThree)
        {
            wrongAnswers[0] = wrongOne;
            wrongAnswers[1] = wrongTwo;
            wrongAnswers[2] = wrongThree;
        }

        public string[] GetWronganswers()
        {
            return wrongAnswers;
        }

        public override string ToString()
        {
            return QuestionText;
        }
    }
}
