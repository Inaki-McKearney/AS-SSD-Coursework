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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
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
