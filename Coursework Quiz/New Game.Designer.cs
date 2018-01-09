namespace Coursework_Quiz
{
    partial class frmNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewGame));
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoArchi = new System.Windows.Forms.RadioButton();
            this.rdoPytha = new System.Windows.Forms.RadioButton();
            this.rdoFibo = new System.Windows.Forms.RadioButton();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnStartQuiz.Location = new System.Drawing.Point(356, 362);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(135, 38);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(497, 362);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(135, 38);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtPlayerName.Location = new System.Drawing.Point(314, 47);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(186, 37);
            this.txtPlayerName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F);
            this.label1.Location = new System.Drawing.Point(98, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F);
            this.label2.Location = new System.Drawing.Point(229, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose an Avatar";
            // 
            // rdoArchi
            // 
            this.rdoArchi.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoArchi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoArchi.BackgroundImage")));
            this.rdoArchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoArchi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoArchi.Location = new System.Drawing.Point(272, 149);
            this.rdoArchi.Name = "rdoArchi";
            this.rdoArchi.Size = new System.Drawing.Size(100, 137);
            this.rdoArchi.TabIndex = 10;
            this.rdoArchi.TabStop = true;
            this.rdoArchi.UseVisualStyleBackColor = true;
            this.rdoArchi.CheckedChanged += new System.EventHandler(this.rdoArchi_CheckedChanged);
            // 
            // rdoPytha
            // 
            this.rdoPytha.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPytha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoPytha.BackgroundImage")));
            this.rdoPytha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoPytha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPytha.Location = new System.Drawing.Point(445, 149);
            this.rdoPytha.Name = "rdoPytha";
            this.rdoPytha.Size = new System.Drawing.Size(100, 137);
            this.rdoPytha.TabIndex = 11;
            this.rdoPytha.TabStop = true;
            this.rdoPytha.UseVisualStyleBackColor = true;
            this.rdoPytha.CheckedChanged += new System.EventHandler(this.rdoPytha_CheckedChanged);
            // 
            // rdoFibo
            // 
            this.rdoFibo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoFibo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdoFibo.BackgroundImage")));
            this.rdoFibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdoFibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoFibo.Location = new System.Drawing.Point(103, 149);
            this.rdoFibo.Name = "rdoFibo";
            this.rdoFibo.Size = new System.Drawing.Size(100, 137);
            this.rdoFibo.TabIndex = 12;
            this.rdoFibo.TabStop = true;
            this.rdoFibo.UseVisualStyleBackColor = true;
            this.rdoFibo.CheckedChanged += new System.EventHandler(this.rdoFibo_CheckedChanged);
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblQuestion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.Location = new System.Drawing.Point(110, 289);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(95, 28);
            this.lblQuestion1.TabIndex = 13;
            this.lblQuestion1.Text = "Fibonacci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Archimedes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pythagoras";
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.rdoFibo);
            this.Controls.Add(this.rdoPytha);
            this.Controls.Add(this.rdoArchi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnStartQuiz);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoArchi;
        private System.Windows.Forms.RadioButton rdoPytha;
        private System.Windows.Forms.RadioButton rdoFibo;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}