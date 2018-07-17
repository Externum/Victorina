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
    public partial class LogInForm : Form
    {
        public LoginController LoginController { get; }

        public LogInForm(LoginController loginController)
        {
            InitializeComponent();
            LoginController = loginController;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginController.Login(LoginTextBox.Text.ToString());
            
        }
    }
}
