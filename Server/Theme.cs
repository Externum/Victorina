using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Theme
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private List<Question> questionsList;

        public Theme (String name, int id)
        {
            Name = name;
            Id = id;
        }

        public void GenerateQuestions(OleDbConnection connection)
        {
            questionsList = new List<Question>();
            Random rnd = new Random();
            string kodeQuery = "SELECT t_kode FROM Themes WHERE t_id = " + Id;
            OleDbCommand commandKode = new OleDbCommand(kodeQuery, connection);
            string baseListName = commandKode.ExecuteScalar().ToString();
            Console.WriteLine(baseListName);
            int[] id = new int[5];
            int cnt = 0;
            while (id.Contains(0))
            {
                int n = rnd.Next(1, 9);
                if (id.Contains(n))
                {
                    continue;
                }
                id[cnt] = n;
                cnt++;
            }
            foreach (int i in id)
            {
                string qestQuery = "SELECT quest FROM " + baseListName + " WHERE id = " + i;
                string rAnsQuery = "SELECT right FROM " + baseListName + " WHERE id = " + i;
                string w1AnsQuery = "SELECT wrong1 FROM " + baseListName + " WHERE id = " + i;
                string w2AnsQuery = "SELECT wrong2 FROM " + baseListName + " WHERE id = " + i;
                string w3AnsQuery = "SELECT wrong3 FROM " + baseListName + " WHERE id = " + i;
                OleDbCommand commandQuest = new OleDbCommand(qestQuery, connection);
                OleDbCommand commandRightAns = new OleDbCommand(rAnsQuery, connection);
                OleDbCommand commandWrongAns1 = new OleDbCommand(w1AnsQuery, connection);
                OleDbCommand commandWrongAns2 = new OleDbCommand(w2AnsQuery, connection);
                OleDbCommand commandWrongAns3 = new OleDbCommand(w3AnsQuery, connection);
                string questionText = commandQuest.ExecuteScalar().ToString();
                string rightAns = commandRightAns.ExecuteScalar().ToString();
                string wrongAns1 = commandWrongAns1.ExecuteScalar().ToString();
                string wrongAns2 = commandWrongAns2.ExecuteScalar().ToString();
                string wrongAns3 = commandWrongAns3.ExecuteScalar().ToString();
                Question question = new Question(
                    commandQuest.ExecuteScalar().ToString(),
                    commandRightAns.ExecuteScalar().ToString(),
                    commandWrongAns1.ExecuteScalar().ToString(),
                    commandWrongAns2.ExecuteScalar().ToString(),
                    commandWrongAns3.ExecuteScalar().ToString());
                questionsList.Add(question);
                int n = qestQuery.Length;
                int m = qestQuery.Length - (i.ToString().Length + 1);
            }
        }

        public List<Question> GetQuestions()
        {
            return questionsList;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
