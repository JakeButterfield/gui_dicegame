using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GUI_Dice_Game
{
    public partial class Form1 : Form
    {
    
        // Variable Declaration:
        #region VariableDeclaration

        public List<int> playerOneRolls = new List<int>();
        public List<int> playerTwoRolls = new List<int>();

        public Dictionary<int, Bitmap> diceImages = new Dictionary<int, Bitmap>()
        {
            { 1, Properties.Resources.dice1 },
            { 2, Properties.Resources.dice2 },
            { 3, Properties.Resources.dice3 },
            { 4, Properties.Resources.dice4 },
            { 5, Properties.Resources.dice5 },
            { 6, Properties.Resources.dice6 },
        };

        public int playerOneScore = 0;
        public int playerTwoScore = 0;

        public int playerOneRoll = 1;
        public int playerTwoRoll = 1;

        public int playerOneTotal = 0;
        public int playerTwoTotal = 0;

        public int turnAmount = 1;

        public string chosenPlayer = "player1";

        public string chosenRoll = "";

        Random randomNumber = new Random();

        #endregion

        // Core Program
        public int DiceRoll()
        {
            int rollResult = randomNumber.Next(1, 7);
            return rollResult;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_startButton_Click(object sender, EventArgs e)
        {
            btn_rollDice.Visible = true;
            btn_finishRoll.Visible = true;

            txt_mainText.Text = "It's Player 1's Turn!";
            txt_subText.Text = "Roll the dice or finish your turn";

            txt_currentRoll.Visible = true;
            box_currentRoll.Visible = true;
            txt_turnAmount.Visible = true;

            btn_exitButton.Visible = false;
            btn_startButton.Visible = false;
        }

        private void btn_rollDice_Click(object sender, EventArgs e)
        {
            int chosenRoll;
            if (chosenPlayer == "player1") { chosenRoll = playerOneRoll; }
            else { chosenRoll = playerTwoRoll; }

            if (chosenRoll <= 5 )
            {
                RollGame(chosenPlayer);
                if (chosenPlayer == "player1") { playerOneRoll = playerOneRoll + 1; }
                else { playerTwoRoll = playerTwoRoll + 1; }
            }
            else
            {
                MessageBox.Show("You have no more rolls! Please finish your turn.");
            }
        }

        public void RollGame(string player)
        {
            int roll = DiceRoll();

            pic_dice.Image = diceImages[roll];

            if (roll == 1)
            {
                MessageBox.Show("You rolled a 1, bad luck!");

                UpdateData(chosenPlayer, roll);

                FinishTurn();

            }
            else
            {
                txt_subText.Text = "You rolled a " + roll.ToString();

                UpdateData(chosenPlayer, roll);
            }

        }

        public void UpdateData(string player, int roll)
        {
            if (roll == 1)
            {
                if (player == "player1")
                {
                    playerOneRolls.Add(roll);
                    playerOneScore = 0;
                }
                else
                {
                    playerTwoRolls.Add(roll);
                    playerTwoScore = 0;
                }

                box_currentRoll.Text = "1";
            }
            else
            {
                if (player == "player1")
                {
                    playerOneRolls.Add(roll);
                    playerOneScore = playerOneScore + roll;
                    playerOneTotal = playerOneTotal + playerOneScore;
                }
                else
                {
                    playerTwoRolls.Add(roll);
                    playerTwoScore = playerTwoScore + roll;
                    playerTwoTotal = playerTwoTotal + playerTwoScore;
                }

                if(chosenRoll == "") { chosenRoll = roll.ToString(); }
                else { chosenRoll = chosenRoll + ", " + roll.ToString(); }

                box_currentRoll.Text = chosenRoll;
            }
        }

        private void btn_finishRoll_Click(object sender, EventArgs e)
        {
            FinishTurn();
        }

        public void FinishTurn()
        {
            int chosenScore;
            int chosenPlayerNum;
            if (chosenPlayer == "player1") { chosenScore = playerOneScore; chosenPlayerNum = 2; }
            else { chosenScore = playerTwoScore; chosenPlayerNum = 1; }

            playerOneRoll = 0;
            playerTwoRoll = 0;

            MessageBox.Show("You finished on a score of " + chosenScore);

            pic_dice.Image = diceImages[1];

            if (chosenPlayer == "player2") { turnAmount = turnAmount + 1; }

            if (turnAmount > 3)
            {
                FinishGame();
            }
            else
            {
                txt_turnAmount.Text = "Turn: " + turnAmount.ToString();

                MessageBox.Show("Now it's Player " + chosenPlayerNum + "'s turn!");

                txt_mainText.Text = "It's Player " + chosenPlayerNum + "'s Turn!";
                txt_subText.Text = "Roll the dice or finish your turn";

                playerOneScore = 0;
                playerTwoScore = 0;

                chosenPlayer = "player" + chosenPlayerNum;
                chosenRoll = "";
                box_currentRoll.Text = "";
            }
        }

        public void FinishGame()
        {
            this.Hide();
            Form2 endResults = new Form2(this);
            endResults.playerOneTotal = playerOneTotal;
            endResults.playerTwoTotal = playerTwoTotal;
            endResults.Show();
        }
    }
}
