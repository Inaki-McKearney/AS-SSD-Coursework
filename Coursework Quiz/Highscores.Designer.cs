namespace Coursework_Quiz
{
    partial class frmHighscores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighscores));
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxHighScore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Highscores";
            // 
            // lbxHighScore
            // 
            this.lbxHighScore.BackColor = System.Drawing.Color.PaleGreen;
            this.lbxHighScore.Font = new System.Drawing.Font("Calibri", 20F);
            this.lbxHighScore.FormattingEnabled = true;
            this.lbxHighScore.ItemHeight = 33;
            this.lbxHighScore.Location = new System.Drawing.Point(110, 98);
            this.lbxHighScore.Name = "lbxHighScore";
            this.lbxHighScore.Size = new System.Drawing.Size(425, 235);
            this.lbxHighScore.TabIndex = 16;
            // 
            // frmHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.lbxHighScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHighscores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxHighScore;

    }
}