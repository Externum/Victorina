using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class ConnectionServer
    {
        const int PORT = 10000;
        public static int nClients = 0;

        ClientHandler cHandler;

        public void OpenConnection()
        {
            try
            {
                TcpListener newListener = new TcpListener(IPAddress.Any, PORT);
                newListener.Start();
                Console.WriteLine("Waiting for connection...");
                TcpClient GameClient = newListener.AcceptTcpClient();
                cHandler = new ClientHandler();
                cHandler.clientSocket = GameClient;

                Thread clientThread = new Thread(new ThreadStart(cHandler.RunClient));
                clientThread.Start();

            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception " + exp);
            }
        }
    }
}
