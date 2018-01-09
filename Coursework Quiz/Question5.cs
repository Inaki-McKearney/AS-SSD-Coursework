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
    public partial class frmQuestion5 : Form
    {
        public frmQuestion5()
        {
            InitializeComponent();
            lblPlayerName.Text = frmNewGame.GetPlayer().GetPlayerName();
        }

        public static int q5Score = 0;

        private void btnFinish_Click_1(object sender, EventArgs e)
        {
            if (cmbA1.Text == "Yes")
            {
                q5Score = q5Score + 5;
            }

            if (cmbA2.Text == "Yes")
            {
                q5Score = q5Score + 5;
            }

            if (cmbA3.Text == "No")
            {
                q5Score = q5Score + 5;
            }

            if (cmbA4.Text == "No")
            {
                q5Score = q5Score + 5;
            }

            if (cmbA5.Text == "Yes")
            {
                q5Score = q5Score + 5;
            }

            if ((cmbA1.Text != "") && (cmbA2.Text != "") && (cmbA3.Text != "") && (cmbA4.Text != "") && (cmbA5.Text != ""))
            {
                frmResults frmResults = new frmResults();
                frmResults.Show();
                frmResults.Activate();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please fill in all blanks");
                q5Score = 0;
            }
        }

        private void btnBlackboard_Click(object sender, EventArgs e)
        {
            frmBlackboard frmBlackboard = new frmBlackboard();
            frmBlackboard.Show();
            frmBlackboard.Activate();
            
        }

        private void frmQuestion5_Load(object sender, EventArgs e)
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
