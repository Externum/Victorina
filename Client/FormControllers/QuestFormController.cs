using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class QuestFormController
    {
        public ClientConnection ClientConnection { get; private set; }
        private static int cntQuestions = 0;

        public QuestFormController(ClientConnection clientConnection)
        {
            ClientConnection = clientConnection;
        }

        public string[] LoadForm()
        {
            Random random = new Random();
            string[] questionData = ClientConnection.LoadQuestionRequest();

            for (int i = (questionData.Length - 1); i >= 1; i--)
            {
                int j = random.Next(2, i + 1);
                var temp = questionData[j];
                questionData[j] = questionData[i];
                questionData[i] = temp;
            }
            return questionData;
        }

        public void AnswerClick(string answer)
        {
            //Random random = new Random();
            ClientConnection.AnswerClickQuestionRequest(answer);

            /*
            string[] questionData = ClientConnection.QuestionRequest();

            for (int i = (questionData.Length - 1); i >= 1; i--)
            {
                int j = random.Next(2, i + 1);
                var temp = questionData[j];
                questionData[j] = questionData[i];
                questionData[i] = temp;
            }
            return questionData;
            */
        }

        public string[] GetNewQuestionData()
        {
            string[] questionData = ClientConnection.QuestionRequest();
            Random random = new Random();

            for (int i = (questionData.Length - 1); i >= 1; i--)
            {
                int j = random.Next(1, i + 1);
                string temp = questionData[j];
                questionData[j] = questionData[i];
                questionData[i] = temp;
            }
            
            return questionData;
        }

        public int CountQuestions()
        {
            cntQuestions++;
            /*
            if (cntQuestions >= 20)
            {
                questionsForm.Visible = false;
                GameResultsForm gameResultsForm = new GameResultsForm(new GameResultsFormController(ClientConnection));
                gameResultsForm.ShowDialog();
            }
            */
            return cntQuestions;
        }

        public void ShowResults(QuestionsForm questionsForm)
        {
            cntQuestions = 0;
            questionsForm.Visible = false;
            GameResultsForm gameResultsForm = new GameResultsForm(new GameResultsFormController(ClientConnection));
            gameResultsForm.ShowDialog();
        }
    }
}
