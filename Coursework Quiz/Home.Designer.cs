namespace Coursework_Quiz
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLastPlayer = new System.Windows.Forms.Label();
            this.lblLastScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(64, 117);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(135, 38);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(64, 230);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(135, 38);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.Location = new System.Drawing.Point(64, 343);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(135, 38);
            this.btnHighScores.TabIndex = 3;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(480, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLastPlayer
            // 
            this.lblLastPlayer.AutoSize = true;
            this.lblLastPlayer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLastPlayer.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblLastPlayer.Location = new System.Drawing.Point(372, 117);
            this.lblLastPlayer.Name = "lblLastPlayer";
            this.lblLastPlayer.Size = new System.Drawing.Size(197, 29);
            this.lblLastPlayer.TabIndex = 5;
            this.lblLastPlayer.Text = "Last Player\'s Score:";
            // 
            // lblLastScore
            // 
            this.lblLastScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLastScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastScore.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastScore.Location = new System.Drawing.Point(372, 149);
            this.lblLastScore.Name = "lblLastScore";
            this.lblLastScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastScore.Size = new System.Drawing.Size(197, 31);
            this.lblLastScore.TabIndex = 6;
            this.lblLastScore.Text = "Score";
            this.lblLastScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.lblLastScore);
            this.Controls.Add(this.lblLastPlayer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLastPlayer;
        private System.Windows.Forms.Label lblLastScore;
    }
}

