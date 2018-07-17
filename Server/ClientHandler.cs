using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Server
{
    class ClientHandler
    {
        public TcpClient clientSocket;
        StreamReader reader;
        NetworkStream writer;
        Game game;
        string user;

        public void RunClient()
        {
            reader = new StreamReader(clientSocket.GetStream(), Encoding.Unicode);
            writer = clientSocket.GetStream();
            try
            {
                AcceptLogin();
                while (true)
                {
                    RequestFromClient();
                }
            }
            catch(Exception)
            {
                clientSocket.Close();
                Environment.Exit(0);
            }
        }

        public void AcceptLogin()
        {

            string returnData;
            returnData = reader.ReadLine();
            user = returnData;
            string answerToClient = "Разрешено\r\n";
            byte[] writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
            writer.Write(writeDataToClt, 0, writeDataToClt.Length);
            Console.WriteLine(user + " подключился");
        }

        public void RequestFromClient()
        {
            const string startReq = "НачатьИгру";
            const string resultReq = "ТаблицаРезультатов";
            const string quitReq = "Выход";
            string readDataFromClt;
            string answerToClient;
            byte[] writeDataToClt;
            readDataFromClt = reader.ReadLine();
            string test = readDataFromClt;
            switch (readDataFromClt)
            {
                case startReq:
                    answerToClient = startReq;
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);
                    Console.WriteLine("Начать игру");
                    PlayGame();
                    break;
                case resultReq:
                    answerToClient = resultReq;
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);
                    Console.WriteLine("Показать результаты");
                    SendAllResults();
                    //EndGame();
                    break;
                case quitReq:
                    answerToClient = quitReq;
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);
                    Console.WriteLine("Выход");
                    EndGame();
                    break;
            }
        }

        public void PlayGame() //запуск игры
        {
            game = new Game();
            int cntThemes = 4;
            string[] themes = GenerateThemes();
            SendThemes(themes);
            for (int i = 0; i < cntThemes; i++)
            {
                RemoveTheme();
            }
            GenerateQuestionsToThemes();
            StartGame();
            SendGameResults();
            SendResultsToBase();
            EndGame();
        }

        public string[] GenerateThemes()
        {
            game.OpenConnectionToBase();
            game.GenerateThemes();
            game.CloseConnectionToBase();

            int n = game.GetTheme().Count;
            string[] themes = new string[n];
            foreach (Theme th in game.GetTheme())
            {
                n--;
                themes[n] = th.ToString();
            }
            themes.Reverse();
            return themes;
        }

        public void SendThemes(string[] themes)
        {
            const string clientReq = "Темы";
            string readDataFromClt;
            string answerToClient;
            byte[] writeDataToClt;
            readDataFromClt = reader.ReadLine();
            Console.WriteLine(readDataFromClt);

            answerToClient = themes.Length.ToString();
            answerToClient += "\r\n";
            writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
            writer.Write(writeDataToClt, 0, writeDataToClt.Length);

            for(int i = 0; i < themes.Length; i++)
            {
                answerToClient = themes[i];
                answerToClient += "\r\n";
                writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                writer.Write(writeDataToClt, 0, writeDataToClt.Length);

                readDataFromClt = reader.ReadLine();
                Console.WriteLine(readDataFromClt);
            }

        }

        public void RemoveTheme()
        {
            string readDataFromClt;
            string answerToClient;
            byte[] writeDataToClt;
            readDataFromClt = reader.ReadLine();
            game.RemoveTheme(readDataFromClt);
            answerToClient = readDataFromClt;
            answerToClient += " удалена\r\n";
            writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
            writer.Write(writeDataToClt, 0, writeDataToClt.Length);
        }

        
        public void GenerateQuestionsToThemes()
        {
            game.OpenConnectionToBase();
            foreach(Theme th in game.GetTheme())
            {
                th.GenerateQuestions(game.myConnection);
            }
            game.CloseConnectionToBase();
        }

        public void StartGame()
        {
            const string clientReq = "Начало";
            string readDataFromClt;
            string answerToClient;
            byte[] writeDataToClt;
            readDataFromClt = reader.ReadLine(); //получили запрос на начало
            Console.WriteLine(readDataFromClt); //отобразили в консоли

            answerToClient = clientReq; //ответитили клиенту о начале
            answerToClient += "\r\n";
            writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
            writer.Write(writeDataToClt, 0, writeDataToClt.Length);


            readDataFromClt = reader.ReadLine(); //запрос на вопрос1 фиксировать не нужно
            Console.WriteLine(readDataFromClt); //отобразили в консоли

            //цикл для тем
            foreach (Theme theme in game.GetTheme())
            {
                //цикл для вопросов
                foreach (Question question in theme.GetQuestions())
                {
                    answerToClient = question.QuestionText; //отправка текста вопроса
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);

                    readDataFromClt = reader.ReadLine(); //клиент подтверждает получение текста вопроса
                    Console.WriteLine(readDataFromClt);
                    //---
                    answerToClient = question.RightAnswer; //отправка верного вариант ответа
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);

                    readDataFromClt = reader.ReadLine(); //клиент подтверждает получение верного варинта ответа
                    Console.WriteLine(readDataFromClt);
                    //---
                    answerToClient = question.GetWronganswers()[0]; //отправка 1 не верного вариант ответа
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);

                    readDataFromClt = reader.ReadLine(); //клиент подтверждает получение 1 не верного вариант ответа
                    Console.WriteLine(readDataFromClt);
                    //---
                    answerToClient = question.GetWronganswers()[1]; //отправка 2 не верного вариант ответа
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);

                    readDataFromClt = reader.ReadLine(); //клиент подтверждает получение 2 не верного вариант ответа
                    Console.WriteLine(readDataFromClt);
                    //---
                    answerToClient = question.GetWronganswers()[2]; //отправка 3 не верного вариант ответа
                    answerToClient += "\r\n";
                    writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                    writer.Write(writeDataToClt, 0, writeDataToClt.Length);

                    readDataFromClt = reader.ReadLine(); //клиент подтверждает получение 3 не верного вариант ответа
                    Console.WriteLine(readDataFromClt);
                    //---
                    CheckAnswer(question); //фиксация ответа на вопрос
                }
            }
        }

        public void CheckAnswer(Question question)
        {
            string wright = "Верно";
            string wrong = "Не верно";

            string readDataFromClt;
            byte[] writeDataToClt;
            readDataFromClt = reader.ReadLine(); //клиент отправляет вариант ответа
            Console.WriteLine(readDataFromClt);

            if(readDataFromClt == question.RightAnswer)
            {
                game.FixAnswers(wright);
                Console.WriteLine(wright);
            }
            else
            {
                game.FixAnswers(wrong);
                Console.WriteLine(wrong);
            }
        }

        public void SendGameResults()
        {
            string[] results = game.GetResults();

            const string clientReq = "Результаты";
            string readDataFromClt;
            string answerToClient;
            byte[] writeDataToClt;

            readDataFromClt = reader.ReadLine(); //получили запрос на кол-во рез-в
            Console.WriteLine(readDataFromClt);

            answerToClient = game.GetResults().Length.ToString(); //отправили размер
            answerToClient += "\r\n";
            writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
            writer.Write(writeDataToClt, 0, writeDataToClt.Length);

            foreach (string result in results)
            {
                
                readDataFromClt = reader.ReadLine(); //получили запрос
                Console.WriteLine(readDataFromClt); //отобразили в консоли

                answerToClient = result; //ответитили клиенту
                answerToClient += "\r\n";
                writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                writer.Write(writeDataToClt, 0, writeDataToClt.Length);
            }
        }

        public void SendResultsToBase()
        {
            string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ThemesAndQuestions.mdb";
            OleDbConnection myConnection = new OleDbConnection(connectString);

            List<string> nicks = new List<string>();
            int wrightAnswers = game.GetWrightAnswers();
            string insertQuery = "INSERT INTO Results (nick, result, played) VALUES ";
            string updateResultQuery = "UPDATE Results SET result = ";
            string updatePlayedQuery = "UPDATE Results SET played = ";
            string nickQuery = "SELECT nick FROM Results";

            myConnection.Open();

            OleDbCommand commandNick = new OleDbCommand(nickQuery, myConnection);
            OleDbDataReader reader = commandNick.ExecuteReader();

            while (reader.Read())
            {
                nicks.Add(reader[0].ToString());
            }
            reader.Close();

            if(nicks.Contains(user))
            {
                string playedQuery = "SELECT played FROM Results WHERE nick = " + "'" + user + "'";
                OleDbCommand commandPlayed = new OleDbCommand(playedQuery, myConnection);
                int played = int.Parse(commandPlayed.ExecuteScalar().ToString());
                played++;

                updateResultQuery += wrightAnswers + " WHERE nick = " + "'" + user + "'";
                OleDbCommand commandResultUpdate = new OleDbCommand(updateResultQuery, myConnection);
                commandResultUpdate.ExecuteNonQuery();

                updatePlayedQuery += played + " WHERE nick = " + "'" + user + "'";
                OleDbCommand commandPlayedUpdate = new OleDbCommand(updatePlayedQuery, myConnection);
                commandPlayedUpdate.ExecuteNonQuery();

                myConnection.Close();
            }
            else
            {
                insertQuery += "('" + user + "', " + wrightAnswers + " 1)";
                OleDbCommand commandInsert = new OleDbCommand(insertQuery, myConnection);
                commandInsert.ExecuteNonQuery();

                myConnection.Close();
            }
        }

        public void EndGame()
        {
            string readDataFromClt;
            byte[] writeDataToClt;
            readDataFromClt = reader.ReadLine();
            string answerToClient = readDataFromClt;
            answerToClient += "\r\n";
            writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
            writer.Write(writeDataToClt, 0, writeDataToClt.Length);
            clientSocket.Close();
            Environment.Exit(0);
        }

        public string[] GetAllResults()
        {
            List<string> readResults = new List<string>();
            string[] results;
            string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ThemesAndQuestions.mdb";
            OleDbConnection myConnection = new OleDbConnection(connectString);
            string baseQuery = "SELECT nick, result, played FROM Results ORDER BY result";
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(baseQuery, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                readResults.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();

            results = new string[readResults.Count];

            for(int i = 0; i < results.Length; i++)
            {
                results[i] = readResults[i];
            }

            foreach(string str in results)
            {
                Console.WriteLine(str);
            }

            myConnection.Close();
            return results;
        }

        public void SendAllResults()
        {
            string[] results = GetAllResults();

            const string clientReq = "Результаты";
            string readDataFromClt;
            string answerToClient;
            byte[] writeDataToClt;

            readDataFromClt = reader.ReadLine(); //получили запрос на кол-во рез-в
            Console.WriteLine(readDataFromClt);

            answerToClient = results.Length.ToString(); //отправили размер
            answerToClient += "\r\n";
            writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
            writer.Write(writeDataToClt, 0, writeDataToClt.Length);

            foreach (string result in results)
            {

                readDataFromClt = reader.ReadLine(); //получили запрос
                Console.WriteLine(readDataFromClt); //отобразили в консоли

                answerToClient = result; //ответитили клиенту
                answerToClient += "\r\n";
                writeDataToClt = Encoding.Unicode.GetBytes(answerToClient);
                writer.Write(writeDataToClt, 0, writeDataToClt.Length);
            }
        }
    }
}
