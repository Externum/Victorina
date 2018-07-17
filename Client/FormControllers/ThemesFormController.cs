using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ThemesFormController
    {
        public ClientConnection ClientConnection { get; private set; }
        private static int cntThemes = 0;

        public ThemesFormController(ClientConnection clientConnection)
        {
            ClientConnection = clientConnection;
        }

        public string[] FillThemes()
        {
            string[] themes = ClientConnection.SendThemesRequest();
            return themes;
        }

        public string RemoveTheme(string themeName)
        {
            string notification = ClientConnection.DeleteThemeRequest(themeName);
            cntThemes++;
            return notification;
        }

        public void CheckThemes(ThemesForm themesForm)
        {
            int themesToDelette = 4;
            if(cntThemes >= 4)
            {
                cntThemes = 0;
                themesForm.Visible = false;
                QuestionsForm questionsForm = new QuestionsForm(new QuestFormController(ClientConnection));
                questionsForm.ShowDialog();
            }
        }

    }
}
