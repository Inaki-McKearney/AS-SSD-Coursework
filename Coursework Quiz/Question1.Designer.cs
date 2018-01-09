namespace Coursework_Quiz
{
    partial class frmQuestion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestion1));
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.btnBlackboard = new System.Windows.Forms.Button();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnNext.Location = new System.Drawing.Point(497, 362);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 38);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 25F);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "(8² ÷ 2) + 4 is a...\r\n";
            // 
            // rdoTrue
            // 
            this.rdoTrue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Font = new System.Drawing.Font("Calibri", 30F);
            this.rdoTrue.Location = new System.Drawing.Point(35, 174);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(287, 59);
            this.rdoTrue.TabIndex = 3;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "Square Number";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // rdoFalse
            // 
            this.rdoFalse.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Font = new System.Drawing.Font("Calibri", 30F);
            this.rdoFalse.Location = new System.Drawing.Point(50, 254);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(258, 59);
            this.rdoFalse.TabIndex = 4;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "Cube Number";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // btnBlackboard
            // 
            this.btnBlackboard.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnBlackboard.Location = new System.Drawing.Point(351, 362);
            this.btnBlackboard.Name = "btnBlackboard";
            this.btnBlackboard.Size = new System.Drawing.Size(135, 38);
            this.btnBlackboard.TabIndex = 5;
            this.btnBlackboard.Text = "Blackboard";
            this.btnBlackboard.UseVisualStyleBackColor = true;
            this.btnBlackboard.Click += new System.EventHandler(this.btnBlackboard_Click);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAvatar.Location = new System.Drawing.Point(532, 200);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(100, 137);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAvatar.TabIndex = 8;
            this.pbxAvatar.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlayerName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.Location = new System.Drawing.Point(532, 168);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(100, 29);
            this.lblPlayerName.TabIndex = 28;
            this.lblPlayerName.Text = "Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.btnBlackboard);
            this.Controls.Add(this.rdoFalse);
            this.Controls.Add(this.rdoTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuestion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question1";
            this.Load += new System.EventHandler(this.frmQuestion1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.Button btnBlackboard;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Label lblPlayerName;
    }
}