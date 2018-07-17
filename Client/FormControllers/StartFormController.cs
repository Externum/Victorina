using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class StartFormController
    {
        public ClientConnection ClientConnection { get; private set; }

        public StartFormController(ClientConnection clientConnection)
        {
            ClientConnection = clientConnection;
        }

        public void StartGame()
        {
            string servAnswer = "НачатьИгру";
            if(ClientConnection.SendGameReqest() == servAnswer)
            {
                ThemesForm themesForm = new ThemesForm(new ThemesFormController(ClientConnection));
                themesForm.ShowDialog();
            }
        }

        public void ResultTableShow()
        {
            string servAnswer = "ТаблицаРезультатов";
            if(ClientConnection.SendResultsTblReqest() == servAnswer)
            {
                AllResultsForm allResultsForm = new AllResultsForm(new AllResultsFormController(ClientConnection));
                allResultsForm.ShowDialog();
            }
        }

        public void Quit()
        {
            string servAnswer = "Выход";
            if(ClientConnection.SendQuitReqest() == servAnswer)
            {
                Console.WriteLine("Выход");
                ClientConnection.EndGame();
            }
        }
    }
}
