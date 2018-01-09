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
    public partial class frmQuestion3 : Form
    {
        public frmQuestion3()
        {
            InitializeComponent();
            lblPlayerName.Text = frmNewGame.GetPlayer().GetPlayerName();
        }

        public static int q3Score = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nudA1.Value == 60)
            {
                q3Score = q3Score + 5;
            }

            if (nudA2.Value == 12)
            {
                q3Score = q3Score + 5;
            }

            if (nudA3.Value == 2)
            {
                q3Score = q3Score + 5;
            }

            if (nudA4.Value == 55)
            {
                q3Score = q3Score + 5;
            }

            if (nudA5.Value == 7)
            {
                q3Score = q3Score + 5;
            }

            if (nudA1.Value == 0 || nudA2.Value == 0 || nudA3.Value == 0 || nudA4.Value == 0 || nudA5.Value == 0)
            {
                MessageBox.Show("Please answer each question");
                q3Score = 0;
            }

            else
            {
                frmQuestion4 frmQuestion4 = new frmQuestion4();
                frmQuestion4.Show();
                frmQuestion4.Activate();
                this.Hide();
            }


        }

        private void btnBlackboard_Click(object sender, EventArgs e)
        {
            frmBlackboard frmBlackboard = new frmBlackboard();

            frmBlackboard.Show();
            frmBlackboard.Activate();
        }

        private void frmQuestion3_Load(object sender, EventArgs e)
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
