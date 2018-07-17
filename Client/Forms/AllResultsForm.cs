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
    public partial class AllResultsForm : Form
    {
        public AllResultsFormController AllResultsFormController { get; private set; }

        public AllResultsForm(AllResultsFormController allResultsFormController)
        {
            InitializeComponent();
            AllResultsFormController = allResultsFormController;
        }

        private void AllResultsForm_Load(object sender, EventArgs e)
        {
            string text = "";
            foreach (string str in AllResultsFormController.ShowAllResults())
            {
                text += str + "\n";
            }
                ResultsTextBox.Text = text;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            AllResultsFormController.CloseForm(this);
        }
    }
}
