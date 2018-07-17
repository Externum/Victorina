using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class LoginController
    {

        public ClientConnection ClientConnection { get; private set; }

        public LoginController(ClientConnection clientConnection)
        {
            ClientConnection = clientConnection;
        }

        public void Login(string login)
        {
            string servAnswer = "Разрешено";
            ClientConnection.CreateConnection();
            if (ClientConnection.SendLogin(login) == servAnswer)
            {
                StartForm startForm = new StartForm(new StartFormController(ClientConnection));
                startForm.ShowDialog();
            }
        }
    }
}
