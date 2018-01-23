using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Dice_Game
{
    public partial class Form2 : Form
    {
        Form1 baseForm;

        public int playerOneTotal;
        public int playerTwoTotal;

        public Form2(Form1 baseform)
        {
            this.baseForm = baseform;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            box_player1Score.Text = playerOneTotal.ToString();
            box_player2Score.Text = playerTwoTotal.ToString();
            txt_winningPlayer.Text = CalculateWinner();
        }

        private void btn_exitGame_Click(object sender, EventArgs e)
        {
            baseForm.Close();
        }

        private string CalculateWinner()
        {
            if (playerOneTotal > playerTwoTotal) { return ("Player One Wins!"); }
            else if(playerOneTotal < playerTwoTotal) { return ("Player Two Wins!"); }
            else { return("It's a truce!"); }
        }
    }
}
