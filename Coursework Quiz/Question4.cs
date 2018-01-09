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
    public partial class frmQuestion4 : Form
    {
        public frmQuestion4()
        {
            InitializeComponent();
            lblPlayerName.Text = frmNewGame.GetPlayer().GetPlayerName();
        }

        public static int q4Score = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (chkA1.Checked == true)
            {
                q4Score = q4Score + 5;
            }

            if (chkA2.Checked == false)
            {
                q4Score = q4Score + 5;
            }

            if (chkA3.Checked == false)
            {
                q4Score = q4Score + 5;
            }

            if (chkA4.Checked == true)
            {
                q4Score = q4Score + 5;
            }

            if (chkA5.Checked == true)
            {
                q4Score = q4Score + 5;
            }          

            if (chkA1.Checked == true || chkA2.Checked == true || chkA3.Checked == true || chkA4.Checked == true || chkA5.Checked == true)
            {
                frmQuestion5 frmQuestion5 = new frmQuestion5();
                frmQuestion5.Show();
                frmQuestion5.Activate();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please check at least one box");
                q4Score = 0;
            }
            
            
        }

        private void btnBlackboard_Click(object sender, EventArgs e)
        {
            frmBlackboard frmBlackboard = new frmBlackboard();

            frmBlackboard.Show();
            frmBlackboard.Activate();
            
        }

        private void frmQuestion4_Load(object sender, EventArgs e)
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
