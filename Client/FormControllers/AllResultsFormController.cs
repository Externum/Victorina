using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class AllResultsFormController
    {
        public ClientConnection ClientConnection { get; private set; }

        public AllResultsFormController(ClientConnection clientConnection)
        {
            ClientConnection = clientConnection;
        }
       
        public string[] ShowAllResults()
        {

            string[] allResults = ClientConnection.ResultRequest();
            Array.Reverse(allResults);

            string[] form;
            char split = ' ';

            for (int i = 0; i < allResults.Length; i++)
            {
                form = allResults[i].Split(split);
                allResults[i] = " ";
                for (int j = 0; j < form.Length; j++)
                {
                    allResults[i] += string.Format($"{form[j],-20}");
                }
            }

            return allResults;
        }

        public void CloseForm(AllResultsForm allResultsForm)
        {
            //ClientConnection.EndGame();
            allResultsForm.Visible = false;
            StartForm startForm = new StartForm(new StartFormController(ClientConnection));
            startForm.ShowDialog();
        }
    }
}
