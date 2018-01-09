namespace Coursework_Quiz
{
    partial class frmQuestion2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestion2));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBlackboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtQ1 = new System.Windows.Forms.TextBox();
            this.txtQ2 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtQ3 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtQ4 = new System.Windows.Forms.TextBox();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.txtQ5 = new System.Windows.Forms.TextBox();
            this.txtA5 = new System.Windows.Forms.TextBox();
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
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBlackboard
            // 
            this.btnBlackboard.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnBlackboard.Location = new System.Drawing.Point(356, 362);
            this.btnBlackboard.Name = "btnBlackboard";
            this.btnBlackboard.Size = new System.Drawing.Size(135, 38);
            this.btnBlackboard.TabIndex = 6;
            this.btnBlackboard.Text = "Blackboard";
            this.btnBlackboard.UseVisualStyleBackColor = true;
            this.btnBlackboard.Click += new System.EventHandler(this.btnBlackboard_Click);
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
            this.label1.TabIndex = 7;
            this.label1.Text = "Question 2";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 25F);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 85);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arange these standard form numbers from highest to lowest (Drag and Drop)";
            // 
            // txtA1
            // 
            this.txtA1.AllowDrop = true;
            this.txtA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtA1.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtA1.Location = new System.Drawing.Point(169, 177);
            this.txtA1.Name = "txtA1";
            this.txtA1.ReadOnly = true;
            this.txtA1.Size = new System.Drawing.Size(115, 37);
            this.txtA1.TabIndex = 10;
            this.txtA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA1.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtA1_DragDrop);
            this.txtA1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtA1_DragEnter);
            // 
            // txtQ1
            // 
            this.txtQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQ1.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtQ1.Location = new System.Drawing.Point(12, 177);
            this.txtQ1.Name = "txtQ1";
            this.txtQ1.Size = new System.Drawing.Size(115, 37);
            this.txtQ1.TabIndex = 11;
            this.txtQ1.Text = "2.3 X 10^3";
            this.txtQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQ1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtQ1_MouseDown);
            // 
            // txtQ2
            // 
            this.txtQ2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQ2.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtQ2.Location = new System.Drawing.Point(12, 220);
            this.txtQ2.Name = "txtQ2";
            this.txtQ2.Size = new System.Drawing.Size(115, 37);
            this.txtQ2.TabIndex = 13;
            this.txtQ2.Text = "1.5 X 10^6";
            this.txtQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQ2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtQ2_MouseDown);
            // 
            // txtA2
            // 
            this.txtA2.AllowDrop = true;
            this.txtA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtA2.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtA2.Location = new System.Drawing.Point(169, 220);
            this.txtA2.Name = "txtA2";
            this.txtA2.ReadOnly = true;
            this.txtA2.Size = new System.Drawing.Size(115, 37);
            this.txtA2.TabIndex = 12;
            this.txtA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA2.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtA2_DragDrop);
            this.txtA2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtA2_DragEnter);
            // 
            // txtQ3
            // 
            this.txtQ3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQ3.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtQ3.Location = new System.Drawing.Point(12, 263);
            this.txtQ3.Name = "txtQ3";
            this.txtQ3.Size = new System.Drawing.Size(115, 37);
            this.txtQ3.TabIndex = 15;
            this.txtQ3.Text = "3.2 X 10^-4";
            this.txtQ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQ3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtQ3_MouseDown);
            // 
            // txtA3
            // 
            this.txtA3.AllowDrop = true;
            this.txtA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtA3.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtA3.Location = new System.Drawing.Point(169, 263);
            this.txtA3.Name = "txtA3";
            this.txtA3.ReadOnly = true;
            this.txtA3.Size = new System.Drawing.Size(115, 37);
            this.txtA3.TabIndex = 14;
            this.txtA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA3.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtA3_DragDrop);
            this.txtA3.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtA3_DragEnter);
            // 
            // txtQ4
            // 
            this.txtQ4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQ4.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtQ4.Location = new System.Drawing.Point(12, 306);
            this.txtQ4.Name = "txtQ4";
            this.txtQ4.Size = new System.Drawing.Size(115, 37);
            this.txtQ4.TabIndex = 17;
            this.txtQ4.Text = "4.6 X 10^7";
            this.txtQ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQ4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtQ4_MouseDown);
            // 
            // txtA4
            // 
            this.txtA4.AllowDrop = true;
            this.txtA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtA4.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtA4.Location = new System.Drawing.Point(169, 306);
            this.txtA4.Name = "txtA4";
            this.txtA4.ReadOnly = true;
            this.txtA4.Size = new System.Drawing.Size(115, 37);
            this.txtA4.TabIndex = 16;
            this.txtA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA4.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtA4_DragDrop);
            this.txtA4.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtA4_DragEnter);
            // 
            // txtQ5
            // 
            this.txtQ5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQ5.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtQ5.Location = new System.Drawing.Point(12, 349);
            this.txtQ5.Name = "txtQ5";
            this.txtQ5.Size = new System.Drawing.Size(115, 37);
            this.txtQ5.TabIndex = 19;
            this.txtQ5.Text = "3.9 X 10^-2";
            this.txtQ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQ5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtQ5_MouseDown);
            // 
            // txtA5
            // 
            this.txtA5.AllowDrop = true;
            this.txtA5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtA5.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtA5.Location = new System.Drawing.Point(169, 349);
            this.txtA5.Name = "txtA5";
            this.txtA5.ReadOnly = true;
            this.txtA5.Size = new System.Drawing.Size(115, 37);
            this.txtA5.TabIndex = 18;
            this.txtA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA5.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtA5_DragDrop);
            this.txtA5.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtA5_DragEnter);
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
            this.pbxAvatar.TabIndex = 20;
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
            // frmQuestion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.txtQ5);
            this.Controls.Add(this.txtA5);
            this.Controls.Add(this.txtQ4);
            this.Controls.Add(this.txtA4);
            this.Controls.Add(this.txtQ3);
            this.Controls.Add(this.txtA3);
            this.Controls.Add(this.txtQ2);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtQ1);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlackboard);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuestion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question2";
            this.Load += new System.EventHandler(this.frmQuestion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBlackboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtQ1;
        private System.Windows.Forms.TextBox txtQ2;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtQ3;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.TextBox txtQ4;
        private System.Windows.Forms.TextBox txtA4;
        private System.Windows.Forms.TextBox txtQ5;
        private System.Windows.Forms.TextBox txtA5;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.Label lblPlayerName;
    }
}