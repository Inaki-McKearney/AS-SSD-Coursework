using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_Quiz
{
    public partial class frmQuestion1 : Form
    {
        public frmQuestion1()
        {
            InitializeComponent();
            lblPlayerName.Text = frmNewGame.GetPlayer().GetPlayerName();
        }

        public static int q1Score;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdoTrue.Checked)
            {
                q1Score = 5;

                frmQuestion2 frmQuestion2 = new frmQuestion2();
                frmQuestion2.Show();
                frmQuestion2.Activate();
                this.Hide();
            }

            else if (rdoFalse.Checked)
            {
                frmQuestion2 frmQuestion2 = new frmQuestion2();
                frmQuestion2.Show();
                frmQuestion2.Activate();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Select an answer");
            }           
        }

        private void btnBlackboard_Click(object sender, EventArgs e)
        {
            frmBlackboard frmBlackboard = new frmBlackboard();

            frmBlackboard.Activate();
            frmBlackboard.Show();
        }

        private void frmQuestion1_Load(object sender, EventArgs e)
        {
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
    }
}

        