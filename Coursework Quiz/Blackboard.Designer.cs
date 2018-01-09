namespace Coursework_Quiz
{
    partial class frmBlackboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBlackboard = new System.Windows.Forms.Panel();
            this.btnErase = new System.Windows.Forms.Button();
            this.pnlBlackboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnClose.Location = new System.Drawing.Point(497, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBlackboard
            // 
            this.pnlBlackboard.BackColor = System.Drawing.Color.Black;
            this.pnlBlackboard.Controls.Add(this.btnErase);
            this.pnlBlackboard.Controls.Add(this.btnClose);
            this.pnlBlackboard.Location = new System.Drawing.Point(-2, -1);
            this.pnlBlackboard.Name = "pnlBlackboard";
            this.pnlBlackboard.Size = new System.Drawing.Size(647, 413);
            this.pnlBlackboard.TabIndex = 2;
            this.pnlBlackboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseDown);
            this.pnlBlackboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseMove);
            this.pnlBlackboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBlackboard_MouseUp);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnErase.Location = new System.Drawing.Point(356, 361);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(135, 38);
            this.btnErase.TabIndex = 2;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // frmBlackboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.pnlBlackboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBlackboard";
            this.Text = "Blackboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blackboard_FormClosing);
            this.Load += new System.EventHandler(this.Blackboard_Load);
            this.pnlBlackboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlBlackboard;
        private System.Windows.Forms.Button btnErase;

    }
}