using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Server
{
    public class Game
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ThemesAndQuestions.mdb";
       
        public OleDbConnection myConnection { get; set; }

        private List<Theme> themesList;
        private static int cnt = 0;
        private int cntQuestions;
        private string[] answers;

        public Game()
        {
            cntQuestions = 20;
            answers = new string[cntQuestions];
        }

        public void OpenConnectionToBase()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        public void CloseConnectionToBase()
        {
            myConnection.Close();
        }

        public void GenerateThemes()
        {
            themesList = new List<Theme>();
            Random rnd = new Random();
            string baseQueryName = "SELECT t_name FROM Themes WHERE t_id = ";
            string query;
            int[] id = new int[8];
            int cnt = 0;
            while(id.Contains(0))
            {
                int n = rnd.Next(1,11);
                if(id.Contains(n))
                {
                    continue;
                }
                id[cnt] = n;
                cnt++;
            }
            foreach(int i in id)
            {
                query = string.Format(baseQueryName + i);
                OleDbCommand command = new OleDbCommand(query, myConnection);
                Theme theme = new Theme(command.ExecuteScalar().ToString(), i);
                themesList.Add(theme);
            }

            foreach(Theme th in themesList)
            {
                Console.WriteLine(th + " " + id);
            }
        }

        public void RemoveTheme(string themeName)
        {
            themesList.Remove(themesList.Find(x => x.Name == themeName));
        }

        public List<Theme> GetTheme()
        {
            return themesList;
        }

        public void FixAnswers(string answer)
        {
            answers[cnt] = answer;
            cnt++;
        }

        public string[] GetResults()
        {
            return answers;
        }

        public int GetWrightAnswers()
        {
            string wright = "Верно";
            int cntWright = 0;
            foreach(string answer in answers)
            {
                if(answer == wright)
                {
                    cntWright++;
                }
            }
            return cntWright;
        }
    }
}
