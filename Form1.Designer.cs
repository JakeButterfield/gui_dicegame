namespace GUI_Dice_Game
{
    partial class Form1
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
            this.pic_dice = new System.Windows.Forms.PictureBox();
            this.txt_mainText = new System.Windows.Forms.Label();
            this.txt_subText = new System.Windows.Forms.Label();
            this.btn_startButton = new System.Windows.Forms.Button();
            this.btn_exitButton = new System.Windows.Forms.Button();
            this.btn_rollDice = new System.Windows.Forms.Button();
            this.btn_finishRoll = new System.Windows.Forms.Button();
            this.box_currentRoll = new System.Windows.Forms.TextBox();
            this.txt_currentRoll = new System.Windows.Forms.Label();
            this.txt_turnAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dice)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_dice
            // 
            this.pic_dice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_dice.Image = global::GUI_Dice_Game.Properties.Resources.dice1;
            this.pic_dice.Location = new System.Drawing.Point(44, 12);
            this.pic_dice.Name = "pic_dice";
            this.pic_dice.Size = new System.Drawing.Size(112, 112);
            this.pic_dice.TabIndex = 0;
            this.pic_dice.TabStop = false;
            // 
            // txt_mainText
            // 
            this.txt_mainText.Location = new System.Drawing.Point(0, 129);
            this.txt_mainText.Name = "txt_mainText";
            this.txt_mainText.Size = new System.Drawing.Size(198, 23);
            this.txt_mainText.TabIndex = 1;
            this.txt_mainText.Text = "Welcome to the Dice Game";
            this.txt_mainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_subText
            // 
            this.txt_subText.Location = new System.Drawing.Point(3, 149);
            this.txt_subText.Name = "txt_subText";
            this.txt_subText.Size = new System.Drawing.Size(195, 23);
            this.txt_subText.TabIndex = 2;
            this.txt_subText.Text = "Press Start to begin";
            this.txt_subText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_startButton
            // 
            this.btn_startButton.Location = new System.Drawing.Point(63, 222);
            this.btn_startButton.Name = "btn_startButton";
            this.btn_startButton.Size = new System.Drawing.Size(75, 34);
            this.btn_startButton.TabIndex = 3;
            this.btn_startButton.Text = "Start";
            this.btn_startButton.UseVisualStyleBackColor = true;
            this.btn_startButton.Click += new System.EventHandler(this.btn_startButton_Click);
            // 
            // btn_exitButton
            // 
            this.btn_exitButton.Location = new System.Drawing.Point(63, 262);
            this.btn_exitButton.Name = "btn_exitButton";
            this.btn_exitButton.Size = new System.Drawing.Size(75, 34);
            this.btn_exitButton.TabIndex = 4;
            this.btn_exitButton.Text = "Exit";
            this.btn_exitButton.UseVisualStyleBackColor = true;
            this.btn_exitButton.Click += new System.EventHandler(this.btn_exitButton_Click);
            // 
            // btn_rollDice
            // 
            this.btn_rollDice.Location = new System.Drawing.Point(63, 222);
            this.btn_rollDice.Name = "btn_rollDice";
            this.btn_rollDice.Size = new System.Drawing.Size(75, 34);
            this.btn_rollDice.TabIndex = 5;
            this.btn_rollDice.Text = "Roll";
            this.btn_rollDice.UseVisualStyleBackColor = true;
            this.btn_rollDice.Visible = false;
            this.btn_rollDice.Click += new System.EventHandler(this.btn_rollDice_Click);
            // 
            // btn_finishRoll
            // 
            this.btn_finishRoll.Location = new System.Drawing.Point(63, 262);
            this.btn_finishRoll.Name = "btn_finishRoll";
            this.btn_finishRoll.Size = new System.Drawing.Size(75, 34);
            this.btn_finishRoll.TabIndex = 6;
            this.btn_finishRoll.Text = "Finish";
            this.btn_finishRoll.UseVisualStyleBackColor = true;
            this.btn_finishRoll.Visible = false;
            this.btn_finishRoll.Click += new System.EventHandler(this.btn_finishRoll_Click);
            // 
            // box_currentRoll
            // 
            this.box_currentRoll.Location = new System.Drawing.Point(74, 175);
            this.box_currentRoll.Name = "box_currentRoll";
            this.box_currentRoll.ReadOnly = true;
            this.box_currentRoll.Size = new System.Drawing.Size(112, 20);
            this.box_currentRoll.TabIndex = 7;
            this.box_currentRoll.Visible = false;
            // 
            // txt_currentRoll
            // 
            this.txt_currentRoll.AutoSize = true;
            this.txt_currentRoll.Location = new System.Drawing.Point(7, 178);
            this.txt_currentRoll.Name = "txt_currentRoll";
            this.txt_currentRoll.Size = new System.Drawing.Size(65, 13);
            this.txt_currentRoll.TabIndex = 8;
            this.txt_currentRoll.Text = "Current Roll:";
            this.txt_currentRoll.Visible = false;
            // 
            // txt_turnAmount
            // 
            this.txt_turnAmount.AutoSize = true;
            this.txt_turnAmount.Location = new System.Drawing.Point(80, 204);
            this.txt_turnAmount.Name = "txt_turnAmount";
            this.txt_turnAmount.Size = new System.Drawing.Size(41, 13);
            this.txt_turnAmount.TabIndex = 9;
            this.txt_turnAmount.Text = "Turn: 1";
            this.txt_turnAmount.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 308);
            this.Controls.Add(this.txt_turnAmount);
            this.Controls.Add(this.txt_currentRoll);
            this.Controls.Add(this.box_currentRoll);
            this.Controls.Add(this.btn_finishRoll);
            this.Controls.Add(this.btn_rollDice);
            this.Controls.Add(this.btn_exitButton);
            this.Controls.Add(this.btn_startButton);
            this.Controls.Add(this.txt_subText);
            this.Controls.Add(this.txt_mainText);
            this.Controls.Add(this.pic_dice);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_dice;
        private System.Windows.Forms.Label txt_mainText;
        private System.Windows.Forms.Label txt_subText;
        private System.Windows.Forms.Button btn_startButton;
        private System.Windows.Forms.Button btn_exitButton;
        private System.Windows.Forms.Button btn_rollDice;
        private System.Windows.Forms.Button btn_finishRoll;
        private System.Windows.Forms.TextBox box_currentRoll;
        private System.Windows.Forms.Label txt_currentRoll;
        private System.Windows.Forms.Label txt_turnAmount;
    }
}

