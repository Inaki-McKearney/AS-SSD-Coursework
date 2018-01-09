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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            GetLastScore();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmNewGame frmNewGame = new frmNewGame();
            frmNewGame.Show();
            frmNewGame.Activate();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();
            frmHelp.Activate();
            this.Hide();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            frmHighscores frmHighscores = new frmHighscores();
            frmHighscores.Show();
            frmHighscores.Activate();
            this.Hide();
        }

        private void GetLastScore()
        {
            try
            {
                BinaryReader b = new BinaryReader(File.Open("Score", FileMode.Open));
                int pos = 0;
                int length = (int)b.BaseStream.Length;

                while (pos < length)
                {
                    string score = b.ReadString();

                    lblLastScore.Text = score;
                    lblLastScore.Visible = true;

                    pos += sizeof(double);
                }

                b.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex);
               lblLastScore.Visible = false;
            }
        }
    }
}
          


    
