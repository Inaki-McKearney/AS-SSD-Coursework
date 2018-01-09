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
    public partial class frmQuestion2 : Form
    {
        public frmQuestion2()
        {
            InitializeComponent();
            lblPlayerName.Text = frmNewGame.GetPlayer().GetPlayerName();
        }

        public static int q2Score = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtA1.Text == "4.6 X 10^7")
            {
                q2Score = q2Score + 5;
            }

            if (txtA2.Text == "1.5 X 10^6")
            {
                q2Score = q2Score + 5;
            }

            if (txtA3.Text == "2.3 X 10^3")
            {
                q2Score = q2Score + 5;
            }

            if (txtA4.Text == "3.9 X 10^-2")
            {
                q2Score = q2Score + 5;
            }

            if (txtA5.Text == "3.2 X 10^-4")
            {
                q2Score = q2Score + 5;
            }

            if (txtA1.Text == "" || txtA2.Text == "" || txtA3.Text == "" || txtA4.Text == "" || txtA5.Text == "")
            {
                MessageBox.Show("Please put all answers in order");
                q2Score = 0;
            }

            else
            {
                frmQuestion3 frmQuestion3 = new frmQuestion3();
                frmQuestion3.Show();
                frmQuestion3.Activate();
                this.Hide();
            }
        }

        //1
        private void txtQ1_MouseDown(object sender, MouseEventArgs e)
        {
            txtQ1.DoDragDrop(txtQ1.Text, DragDropEffects.Copy);
        }

        private void txtA1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = e.AllowedEffect;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtA1_DragDrop(object sender, DragEventArgs e)
        {
            txtA1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        //2
        private void txtQ2_MouseDown(object sender, MouseEventArgs e)
        {
            txtQ2.DoDragDrop(txtQ2.Text, DragDropEffects.Copy);
        }

        private void txtA2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = e.AllowedEffect;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtA2_DragDrop(object sender, DragEventArgs e)
        {
            txtA2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        //3
        private void txtQ3_MouseDown(object sender, MouseEventArgs e)
        {
            txtQ3.DoDragDrop(txtQ3.Text, DragDropEffects.Copy);
        }

        private void txtA3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = e.AllowedEffect;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtA3_DragDrop(object sender, DragEventArgs e)
        {
            txtA3.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        //4
        private void txtQ4_MouseDown(object sender, MouseEventArgs e)
        {
            txtQ4.DoDragDrop(txtQ4.Text, DragDropEffects.Copy);
        }

        private void txtA4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = e.AllowedEffect;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtA4_DragDrop(object sender, DragEventArgs e)
        {
            txtA4.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        //5
        private void txtQ5_MouseDown(object sender, MouseEventArgs e)
        {
            txtQ5.DoDragDrop(txtQ5.Text, DragDropEffects.Copy);
        }

        private void txtA5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = e.AllowedEffect;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtA5_DragDrop(object sender, DragEventArgs e)
        {
            txtA5.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void btnBlackboard_Click(object sender, EventArgs e)
        {
            frmBlackboard frmBlackboard = new frmBlackboard();
            frmBlackboard.Show();
            frmBlackboard.Activate();
        }

        private void frmQuestion2_Load(object sender, EventArgs e)
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
