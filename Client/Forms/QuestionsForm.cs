using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class QuestionsForm : Form
    {
        private QuestFormController QuestFormController { get; }

        public QuestionsForm(QuestFormController questFormController)
        {
            InitializeComponent();
            QuestFormController = questFormController;
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            string[] data = QuestFormController.LoadForm();
            QuestionTextBox.Text = data[0];
            Answer1Button.Text = data[1];
            Answer2Button.Text = data[2];
            Answer3Button.Text = data[3];
            Answer4Button.Text = data[4];
        }

        private void Answer1Button_Click(object sender, EventArgs e)
        {
            QuestFormController.AnswerClick(Answer1Button.Text);
            int cntQuest = QuestFormController.CountQuestions();
            if (cntQuest < 20)
            {
                string[] data = QuestFormController.GetNewQuestionData();
                QuestionTextBox.Text = data[0];
                Answer1Button.Text = data[1];
                Answer2Button.Text = data[2];
                Answer3Button.Text = data[3];
                Answer4Button.Text = data[4];
            }
            else
            {
                QuestFormController.ShowResults(this);
            }
        }

        private void Answer2Button_Click(object sender, EventArgs e)
        {
            QuestFormController.AnswerClick(Answer2Button.Text);
            int cntQuest = QuestFormController.CountQuestions();
            if (cntQuest < 20)
            {
                string[] data = QuestFormController.GetNewQuestionData();
                QuestionTextBox.Text = data[0];
                Answer1Button.Text = data[1];
                Answer2Button.Text = data[2];
                Answer3Button.Text = data[3];
                Answer4Button.Text = data[4];
            }
            else
            {
                QuestFormController.ShowResults(this);
            }
        }

        private void Answer3Button_Click(object sender, EventArgs e)
        {
            QuestFormController.AnswerClick(Answer3Button.Text);
            int cntQuest = QuestFormController.CountQuestions();
            if (cntQuest < 20)
            {
                string[] data = QuestFormController.GetNewQuestionData();
                QuestionTextBox.Text = data[0];
                Answer1Button.Text = data[1];
                Answer2Button.Text = data[2];
                Answer3Button.Text = data[3];
                Answer4Button.Text = data[4];
            }
            else
            {
                QuestFormController.ShowResults(this);
            }
        }

        private void Answer4Button_Click(object sender, EventArgs e)
        {
            QuestFormController.AnswerClick(Answer4Button.Text);
            int cntQuest = QuestFormController.CountQuestions();
            if (cntQuest < 20)
            {
                string[] data = QuestFormController.GetNewQuestionData();
                QuestionTextBox.Text = data[0];
                Answer1Button.Text = data[1];
                Answer2Button.Text = data[2];
                Answer3Button.Text = data[3];
                Answer4Button.Text = data[4];
            }
            else
            {
                QuestFormController.ShowResults(this);
            }
        }

        private void QuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
