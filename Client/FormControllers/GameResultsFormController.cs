using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class GameResultsFormController
    {
        public ClientConnection ClientConnection { get; private set; }
        string[] results;
        int[] cntResults;

        public GameResultsFormController(ClientConnection clientConnection)
        {
            ClientConnection = clientConnection;
        }

        public string[] ShowResults()
        {
            results = ClientConnection.ResultRequest();
            return results;
        }

        public void CloseForm()
        {
            ClientConnection.EndGame();
            /*
            gameResultsForm.Visible = false;
            StartForm startForm = new StartForm(new StartFormController(ClientConnection));
            startForm.ShowDialog();
            */
        }

        public int[] CountResults()
        {
            string wright = "Верно";
            int cntWright = 0;
            int cntWrong = 0;
            for(int i = 0; i < results.Length; i++)
            {
                if(results[i] == wright)
                {
                    cntWright++;
                }
                else
                {
                    cntWrong++;
                }
            }
            cntResults = new int[] { cntWright, cntWrong };
            return cntResults;
        }
    }
}
