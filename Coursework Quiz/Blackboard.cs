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
    public partial class frmBlackboard : Form
    {
        public frmBlackboard()
        {
            InitializeComponent();
        }

        bool mousePress;
        int xLast;
        int yLast;
        Graphics myGraphics;
        Pen myPen;

        private void Blackboard_Load(object sender, EventArgs e)
        {
           
            myGraphics = pnlBlackboard.CreateGraphics();
            myPen = new Pen(Color.White, 5);
            
           
            mousePress = false;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(pnlBlackboard.BackColor);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBlackboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePress = true;
                xLast = e.X;
                yLast = e.Y;
            }
        }

        private void pnlBlackboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePress)
            {
                myGraphics.DrawLine(myPen, xLast, yLast, e.X, e.Y);
                xLast = e.X;
                yLast = e.Y;
            }
        }

        private void pnlBlackboard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                myGraphics.DrawLine(myPen, xLast, yLast, e.X, e.Y);
                mousePress = false;
            }
        }

        private void Blackboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGraphics.Dispose();
            myPen.Dispose();
        }
    }
}
