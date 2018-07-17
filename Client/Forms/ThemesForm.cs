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
    public partial class ThemesForm : Form
    {
        public ThemesFormController ThemesFormController { get; private set; }

        public ThemesForm(ThemesFormController themesFormController)
        {
            InitializeComponent();
            ThemesFormController = themesFormController;
        }

        private void Themes_Load(object sender, EventArgs e)
        {
            string[] themes = ThemesFormController.FillThemes();
            int n = (themes.Length) - 1;
            Theme1Button.Text = themes[n];
            n--;
            Theme2Button.Text = themes[n];
            n--;
            Theme3Button.Text = themes[n];
            n--;
            Theme4Button.Text = themes[n];
            n--;
            Theme5Button.Text = themes[n];
            n--;
            Theme6Button.Text = themes[n];
            n--;
            Theme7Button.Text = themes[n];
            n--;
            Theme8Button.Text = themes[n];
            n--;
        }

        private void Theme1Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme1Button.Text);
            Theme1Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }

        private void Theme2Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme2Button.Text);
            Theme2Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }

        private void Theme3Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme3Button.Text);
            Theme3Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }

        private void Theme4Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme4Button.Text);
            Theme4Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }

        private void Theme5Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme5Button.Text);
            Theme5Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }

        private void Theme6Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme6Button.Text);
            Theme6Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }

        private void Theme7Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme7Button.Text);
            Theme7Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }

        private void Theme8Button_Click(object sender, EventArgs e)
        {
            NotificationTextBox.Text = ThemesFormController.RemoveTheme(Theme8Button.Text);
            Theme8Button.BackColor = Color.Red;
            ThemesFormController.CheckThemes(this);
        }





        private void NotificationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
