using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ProgramClient
    {
        static void Main(string[] args)
        {
            LogInForm logInForm = new LogInForm(new LoginController(new ClientConnection()));
            logInForm.ShowDialog();
        }
    }
}
