using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coursework_Quiz
{
    public partial class frmHighscores : Form
    {
        public frmHighscores()
        {
            InitializeComponent();            
            WritePlayerTextFile();
            GetPlayerHighScores();                      
        }

        private void GetPlayerHighScores()
        {
            if (File.Exists("playerscore.txt"))
            {
                List<string> users = File.ReadLines("playerscore.txt").ToList();
                List<string> formattedUsers = new List<string>();
                Dictionary<string, int> userNamesAndScores = new Dictionary<string, int>();

                for (int i = 0; i < users.Count; i++)
                {
                    string[] userNameScore = users[i].Split(',');
                    int userScore = Convert.ToInt32(userNameScore[0]);
                    string userName = userNameScore[1];
                    if (userNamesAndScores.ContainsKey(userName))
                    {
                        int numberOfUsersWithSameName = userNamesAndScores.Count(x => x.Key.Contains(userName));
                        userName = userName + string.Format("({0})", numberOfUsersWithSameName);
                    }

                    userNamesAndScores.Add(userName, userScore);

                }

                var sortedUserNamesAndScores = userNamesAndScores.OrderByDescending(x => x.Value);

                foreach (var userNameAndScore in sortedUserNamesAndScores)
                {
                    string highScoreEntry = string.Format("{0} → Score: {1}%", userNameAndScore.Key, userNameAndScore.Value);
                    formattedUsers.Add(highScoreEntry);
                }


                lbxHighScore.DataSource = formattedUsers;
            }

        }

        private void WritePlayerTextFile()
        {
            if (frmResults.totalPercentage > 0)
            {           
            FileStream fs;
            if (File.Exists("playerscore.txt"))
            {
                fs = new FileStream("playerscore.txt", FileMode.Append);
            }

            else
            {
                fs = new FileStream("playerscore.txt", FileMode.Create);
            }

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(frmResults.totalPercentage + "," + frmNewGame.player.GetPlayerName());

            frmResults.totalPercentage = 0;

            sw.Close();
            fs.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();

            frmHome.Show();
            frmHome.Activate();
            this.Hide();
        }

    }
}
