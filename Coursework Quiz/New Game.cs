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
    public partial class frmNewGame : Form
    {
        public static Player player;

        public static Player GetPlayer()
        {
            return player;
        }

        public frmNewGame()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public static int switchAvatar;
        public static string playerName;
        bool start = false;

        private void btnStart_Click(object sender, EventArgs e)
        {

            player = new Player(txtPlayerName.Text);
            
            if (start == true && txtPlayerName.Text.Length > 0)
            {
                frmQuestion1 frmQuestion1 = new frmQuestion1();
                frmQuestion1.Show();
                frmQuestion1.Activate();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please enter your name and select an avatar.");
            }       
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();

            frmHome.Show();
            frmHome.Activate();
            this.Hide();
        }

        private void rdoFibo_CheckedChanged(object sender, EventArgs e)
        {
            switchAvatar = 0;
            rdoFibo.FlatStyle = FlatStyle.Popup;
            rdoPytha.FlatStyle = FlatStyle.Standard;
            rdoArchi.FlatStyle = FlatStyle.Standard;
            start = true;
        }

        private void rdoArchi_CheckedChanged(object sender, EventArgs e)
        {
            switchAvatar = 1;
            rdoFibo.FlatStyle = FlatStyle.Standard;
            rdoPytha.FlatStyle = FlatStyle.Standard;
            rdoArchi.FlatStyle = FlatStyle.Popup;
            start = true;
        }

        private void rdoPytha_CheckedChanged(object sender, EventArgs e)
        {
            switchAvatar = 2;
            rdoFibo.FlatStyle = FlatStyle.Standard;
            rdoPytha.FlatStyle = FlatStyle.Popup;
            rdoArchi.FlatStyle = FlatStyle.Standard;
            start = true;
        }
    }
}
