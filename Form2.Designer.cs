namespace GUI_Dice_Game
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_player1Score = new System.Windows.Forms.Label();
            this.box_player1Score = new System.Windows.Forms.TextBox();
            this.box_player2Score = new System.Windows.Forms.TextBox();
            this.txt_player2Score = new System.Windows.Forms.Label();
            this.txt_winningPlayer = new System.Windows.Forms.Label();
            this.btn_exitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over!";
            // 
            // txt_player1Score
            // 
            this.txt_player1Score.AutoSize = true;
            this.txt_player1Score.Location = new System.Drawing.Point(44, 81);
            this.txt_player1Score.Name = "txt_player1Score";
            this.txt_player1Score.Size = new System.Drawing.Size(82, 13);
            this.txt_player1Score.TabIndex = 1;
            this.txt_player1Score.Text = "Player 1 Score: ";
            // 
            // box_player1Score
            // 
            this.box_player1Score.Location = new System.Drawing.Point(132, 78);
            this.box_player1Score.Name = "box_player1Score";
            this.box_player1Score.ReadOnly = true;
            this.box_player1Score.Size = new System.Drawing.Size(100, 20);
            this.box_player1Score.TabIndex = 2;
            // 
            // box_player2Score
            // 
            this.box_player2Score.Location = new System.Drawing.Point(132, 102);
            this.box_player2Score.Name = "box_player2Score";
            this.box_player2Score.ReadOnly = true;
            this.box_player2Score.Size = new System.Drawing.Size(100, 20);
            this.box_player2Score.TabIndex = 4;
            // 
            // txt_player2Score
            // 
            this.txt_player2Score.AutoSize = true;
            this.txt_player2Score.Location = new System.Drawing.Point(44, 105);
            this.txt_player2Score.Name = "txt_player2Score";
            this.txt_player2Score.Size = new System.Drawing.Size(82, 13);
            this.txt_player2Score.TabIndex = 3;
            this.txt_player2Score.Text = "Player 2 Score: ";
            // 
            // txt_winningPlayer
            // 
            this.txt_winningPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_winningPlayer.Location = new System.Drawing.Point(1, 145);
            this.txt_winningPlayer.Name = "txt_winningPlayer";
            this.txt_winningPlayer.Size = new System.Drawing.Size(281, 25);
            this.txt_winningPlayer.TabIndex = 5;
            this.txt_winningPlayer.Text = "It\'s a truce!";
            this.txt_winningPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exitGame
            // 
            this.btn_exitGame.Location = new System.Drawing.Point(103, 183);
            this.btn_exitGame.Name = "btn_exitGame";
            this.btn_exitGame.Size = new System.Drawing.Size(75, 23);
            this.btn_exitGame.TabIndex = 6;
            this.btn_exitGame.Text = "Exit";
            this.btn_exitGame.UseVisualStyleBackColor = true;
            this.btn_exitGame.Click += new System.EventHandler(this.btn_exitGame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.btn_exitGame);
            this.Controls.Add(this.txt_winningPlayer);
            this.Controls.Add(this.box_player2Score);
            this.Controls.Add(this.txt_player2Score);
            this.Controls.Add(this.box_player1Score);
            this.Controls.Add(this.txt_player1Score);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_player1Score;
        private System.Windows.Forms.TextBox box_player1Score;
        private System.Windows.Forms.TextBox box_player2Score;
        private System.Windows.Forms.Label txt_player2Score;
        private System.Windows.Forms.Label txt_winningPlayer;
        private System.Windows.Forms.Button btn_exitGame;
    }
}