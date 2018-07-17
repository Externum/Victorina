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
    public partial class GameResultsForm : Form
    {
        public GameResultsFormController GameResultsFormController { get; private set; }

        public GameResultsForm(GameResultsFormController gameResultsFormController)
        {
            InitializeComponent();
            GameResultsFormController = gameResultsFormController;
        }

        private void GameResultsForm_Load(object sender, EventArgs e)
        {
            ResultsListBox.DataSource = GameResultsFormController.ShowResults();
            int[] cntResults = GameResultsFormController.CountResults();
            WrightResultsTextBox.Text = cntResults[0].ToString();
            WrongResultsTextBox.Text = cntResults[1].ToString();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GameResultsFormController.CloseForm();
        }
    }
}
