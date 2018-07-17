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
    public partial class StartForm : Form
    {
        public StartFormController StartFormController { get; set; }

        public StartForm(StartFormController startFormController)
        {
            InitializeComponent();
            StartFormController = startFormController;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartFormController.StartGame();
        }

        private void RatingTableButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartFormController.ResultTableShow();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartFormController.Quit();
        }
    }
}
