using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity13
{
    public partial class ticTacToeFrm : Form
    {
        public ticTacToeFrm()
        {
            InitializeComponent();
        }

        private void ticTacToeFrm_Load(object sender, EventArgs e)
        {
            
        }
        
        private void ticTactoe()
        {
            //Creating multidimensional string array to store the text in the button objects
            string[,] game =  { { button1.Text, button2.Text, button3.Text }, 
               { button4.Text, button5.Text, button6.Text }, { button7.Text, button8.Text, button9.Text  } };
               //Try block to control any possible errors that may occur. 
               // The biggest one that occurred was a null reference error and index out of bounds exception.
               // Problem was resolved with declaring my array differently and altering the way that I was using it.
            try
            {
                //Check rows, columns, and diagonals to verify for any wins or draws

                if (game[0, 0] == "X" && game[0, 1] == "X" && game[0, 2] == "X")
                {
                    winnerTxt.Text = "X Wins";
                }
                else if (game[0, 0] == "O" && game[0, 1] == "O" && game[0, 2] == "O")
                {
                    winnerTxt.Text = "O Wins";
                }
                if(game[1, 0] == "X" && game[1, 1] == "X" && game[1, 2] == "X")
                {
                    winnerTxt.Text = "X Wins";
                }
                else if(game[1, 0] == "O" && game[1, 1] == "O" && game[1, 2] == "O")
                {
                    winnerTxt.Text = "O Wins";
                }
                if (game[2, 0] == "X" && game[2, 1] == "X" && game[2, 2] == "X")
                {
                    winnerTxt.Text = "X Wins";
                }
                else if (game[2, 0] == "O" && game[2, 1] == "O" && game[2, 2] == "O")
                {
                    winnerTxt.Text = "O Wins";
                }
                if (game[0, 0] == "X" && game[1, 1] == "X" && game[2, 2] == "X")
                {
                    winnerTxt.Text = "X Wins";
                }
                else if (game[0, 0] == "O" && game[1, 1] == "O" && game[2, 2] == "O")
                {
                    winnerTxt.Text = "O Wins";
                }
                if (game[0, 2] == "X" && game[1, 1] == "X" && game[2, 0] == "X")
                {
                    winnerTxt.Text = "X Wins";
                }
                else if (game[0, 2] == "O" && game[1, 1] == "O" && game[2, 0] == "O")
                {
                    winnerTxt.Text = "O Wins";
                }
                //Checking for draw, if none of the buttons match across a row 
                //  or down a column, display "draw"
                if(game[0,0] != "" && game[0, 1] != "" && game[0, 2] != ""
                    && game[1, 0] != "" && game[1, 1] != "" && game[1, 2] != ""
                    && game[2, 0] != "" && game[2, 1] != "" && game[2, 2] != "")
                {
                    winnerTxt.Text = "Draw";
                }
            }
            catch(Exception ex) { MessageBox.Show("Could not perform action.");
            
        }
        
        int player = 0;
        //Performed same task for every button object.
        
        private void button1_Click(object sender, EventArgs e)
        {
        // Player starts at 0 since player one is always X
            if(player == 0)
            {
                button1.Text = "X";
                // Increment player by 1 after each click, player is now 'O'
                player++;
            }
            else 
            { 
                button1.Text = "O";
                // Player now returns to 'X'
                player--;
            }
            // Disable button
            button1.Enabled = false;
            // Call ticTacToe() to check for wins, draws, and losses.
            ticTactoe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button2.Text = "X";
                player++;
            }
            else
            {
                button2.Text = "O";
                player--;
            }
            button2.Enabled = false;
            ticTactoe();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button3.Text = "X";
                player++;
            }
            else
            {
                button3.Text = "O";
                player--;
            }
            button3.Enabled = false;
            ticTactoe();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button4.Text = "X";
                player++;
            }
            else
            {
                button4.Text = "O";
                player--;
            }
            button4.Enabled = false;
            ticTactoe();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button5.Text = "X";
                player++;
            }
            else
            {
                button5.Text = "O";
                player--;
            }
            button5.Enabled = false;
            ticTactoe();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button6.Text = "X";
                player++;
            }
            else
            {
                button6.Text = "O";
                player--;
            }
            button6.Enabled = false;
            ticTactoe();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button7.Text = "X";
                player++;
            }
            else
            {
                button7.Text = "O";
                player--;
            }
            button7.Enabled = false;
            ticTactoe();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button8.Text = "X";
                player++;
            }
            else
            {
                button8.Text = "O";
                player--;
            }
            button8.Enabled = false;
            ticTactoe();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                button9.Text = "X";
                player++;
            }
            else
            {
                button9.Text = "O";
                player--;
            }
            button9.Enabled = false;
            ticTactoe();
        }
    }
}
