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
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();
            lblPlayerName.Text = frmNewGame.GetPlayer().GetPlayerName();
        }

        public static double totalPercentage = 0;

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            frmHighscores frmHighscores = new frmHighscores();
            frmHighscores.Show();
            frmHighscores.Activate();
            this.Hide();
        }
      
       public void frmResults_Load(object sender, EventArgs e)
        {
            lblQ1Score.Text = Convert.ToString(frmQuestion1.q1Score);
            lblQ2Score.Text = Convert.ToString(frmQuestion2.q2Score);
            lblQ3Score.Text = Convert.ToString(frmQuestion3.q3Score);
            lblQ4Score.Text = Convert.ToString(frmQuestion4.q4Score);
            lblQ5Score.Text = Convert.ToString(frmQuestion5.q5Score);
           
            double total = (frmQuestion1.q1Score + frmQuestion2.q2Score + frmQuestion3.q3Score + frmQuestion4.q4Score + frmQuestion5.q5Score);
            totalPercentage = Math.Round((total / 105), 2) * 100;
            
            lblTotalPercentage.Text = Convert.ToString(totalPercentage) + "%";         

            AttemptWriteScore();

            frmQuestion1.q1Score = 0;
            frmQuestion2.q2Score = 0;
            frmQuestion3.q3Score = 0;
            frmQuestion4.q4Score = 0;
            frmQuestion5.q5Score = 0;

            if (totalPercentage >= 50)
            {
                lblTotalPercentage.ForeColor = Color.Green;
            }

            else
            {
                lblTotalPercentage.ForeColor = Color.Red;
            }

            switch (frmNewGame.switchAvatar)
            {
                case 0:
                    pbxAvatar.BackgroundImage = Coursework_Quiz.Properties.Resources.Fibonacci;
                    pbxAvatar.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                    

                case 1:
                    pbxAvatar.BackgroundImage = Coursework_Quiz.Properties.Resources.Archimedes;
                    pbxAvatar.BackgroundImageLayout = ImageLayout.Zoom;
                    break;

                case 2:
                    pbxAvatar.BackgroundImage = Coursework_Quiz.Properties.Resources.Pythagoras;
                    pbxAvatar.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
            }
        }

        

        private void AttemptWriteScore()
        {                      
            try
            {
                BinaryWriter b = new BinaryWriter(File.Open("Score", FileMode.Create));
  
                b.Write(totalPercentage.ToString()+ "%");
                b.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex);
            }
        }
    }
}