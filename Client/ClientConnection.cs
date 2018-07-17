using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ClientConnection
    {

        const int PORT = 10000;
        public TcpClient NewClient { get; set; }
        public NetworkStream Writer { get; set; }
        public StreamReader Reader { get; set; }

        public void CreateConnection()
        {
            try
            {
                NewClient = new TcpClient();
                NewClient.Connect("127.0.0.1", PORT);
                Writer = NewClient.GetStream();
                Reader = new StreamReader(NewClient.GetStream(), Encoding.Unicode);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception: " + exp);
            }
        }

        public string SendLogin(string login)
        {
            
            string userLogin = login;
            userLogin += "\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(userLogin);
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length); 
            return Reader.ReadLine();
        }

        public string SendGameReqest()
        {
            string request = "НачатьИгру\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request);
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            return Reader.ReadLine();
        }

        public string SendResultsTblReqest()
        {
            string request = "ТаблицаРезультатов\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request);
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            return Reader.ReadLine();
        }

        public string SendQuitReqest()
        {
            string request = "Выход\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request);
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            return Reader.ReadLine();
        }

        public string[] SendThemesRequest()
        {
            string request = "Темы\r\n";
            string[] themes;
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request);
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);

            int arrLength = int.Parse(Reader.ReadLine());

            themes = new string[arrLength];

            for(int i = 0; i < arrLength; i++)
            {
                themes[i] = Reader.ReadLine();
                string confirm = i.ToString();
                confirm += "\r\n";
                byteCltToServr = Encoding.Unicode.GetBytes(confirm);
                Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            }
            return themes;
        }

        public string DeleteThemeRequest(string theme)
        {
            string request = theme;
            request += "\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request);
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            string confirm = Reader.ReadLine();
            return confirm;
        }

        public string[] LoadQuestionRequest()
        {
            int objectsReturn = 5;
            string request = "Начало";
            request += "\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request); //запрос начала игры
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);

            string servStartGame = Reader.ReadLine(); //подтверждение начала

            request = "Вопрос";
            request += "\r\n";
            byteCltToServr = Encoding.Unicode.GetBytes(request); //запрос вопроса
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);

            string[] questData = new string[objectsReturn]; //переменная для хранения информации о вопросе

            for (int i = 0; i < objectsReturn; i++) //поочередная фиксация, текста вопроса и вариантов ответа
            {
                questData[i] = Reader.ReadLine(); 
                string confirm = i.ToString();
                confirm += "\r\n";
                byteCltToServr = Encoding.Unicode.GetBytes(confirm);
                Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            }

            return questData;
        }

        public void AnswerClickQuestionRequest(string answer)
        {
            string request = answer;
            request += "\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request);
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length); //отправка выбранного варианта ответа
        }

        public string[] QuestionRequest()
        {
            int objectsReturn = 5;
            string[] questData = new string[objectsReturn];

            for (int i = 0; i < objectsReturn; i++) //поочередная фиксация, текста вопроса и вариантов ответа
            {
                questData[i] = Reader.ReadLine();
                string confirm = i.ToString();
                confirm += "\r\n";
                byte[] byteCltToServr = Encoding.Unicode.GetBytes(confirm);
                Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            }
            return questData;
        }

        public string[] ResultRequest()
        {
            string[] results;
            string request = "Результаты";
            request += "\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request); //отправили запрос результатов
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);

            int resultsLength = int.Parse(Reader.ReadLine()); //ответ от серевера - размер массива
            results = new string[resultsLength]; //массив результатов

            for(int i = 0; i < resultsLength; i++ )
            {
                request = i.ToString();
                request += "\r\n";
                byteCltToServr = Encoding.Unicode.GetBytes(request); //отправили запрос результа
                Writer.Write(byteCltToServr, 0, byteCltToServr.Length);

                results[i] = Reader.ReadLine();
            }

            return results;
        }

        public void EndGame()
        {
            string request = "Завешить игру";
            request += "\r\n";
            byte[] byteCltToServr = Encoding.Unicode.GetBytes(request); //запрос заверешения игры
            Writer.Write(byteCltToServr, 0, byteCltToServr.Length);
            Console.WriteLine(Reader.ReadLine()); //ответ сервера о завершении
            NewClient.Close();
        }
    }
}
