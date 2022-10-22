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
        int player = 0;
        private void ticTactoe()
        {
            //string[,] game = { { button1.Text, button2.Text, button3.Text }, 
            //    { button4.Text, button5.Text, button6.Text }, { button7.Text, button8.Text, button9.Text  } };
            //string[][] game = new string[3][];
            string[,] game =  { { button1.Text, button2.Text, button3.Text }, 
               { button4.Text, button5.Text, button6.Text }, { button7.Text, button8.Text, button9.Text  } };
            try
            {
                //game[0] = new string[{ {button1.Text };] ;
                //game[0] = new string[1];
                //game[0] = new string[2];
                //game[1] = new string[0];
                //game[1] = new string[1];
                //game[1] = new string[2];
                //game[2] = new string[0];
                //game[2] = new string[1];
                //game[2] = new string[2];
                //game[0][0] = button1.Text;
                //game[0][1] = button2.Text;
                //game[0][2] = button3.Text;
                //game[1][0] = button4.Text;
                //game[1][1] = button5.Text;
                //game[1][2] = button6.Text;
                //game[2][0] = button7.Text;
                //game[2][1] = button8.Text;
                //game[2][2] = button9.Text;

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
                if(game[0,0] != "" && game[0, 1] != "" && game[0, 2] != ""
                    && game[1, 0] != "" && game[1, 1] != "" && game[1, 2] != ""
                    && game[2, 0] != "" && game[2, 1] != "" && game[2, 2] != "")
                {
                    winnerTxt.Text = "Draw";
                }
            }
            catch(Exception ex) { MessageBox.Show("Could not perform");  }
           
            //for(int i = 0; i < game.Length; i++)
            //{
            //    for(int j = 0; j < game[i].Length; j++)
            //    {
            //        if (game[i][j] != "")
            //        {
            //            winnerTxt.Text = "Draw";
            //        }
            //        if (player == 0)
            //        {
            //            game[i][j] = "X";
            //            player++;
            //        }
            //        else if (player == 1)
            //        {
            //            game[i][j] = "O";
            //            player--;
            //        }
                    
            //    }
            //}
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(player == 0)
            {
                button1.Text = "X";
                player++;
            }
            else 
            { 
                button1.Text = "O";
                player--;
            }
            button1.Enabled = false;
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







 
            
            //    winnerTxt.Text = "Draw";
            //}


        
        
        //private void button1Click()
        //{
        //    if(player == 0)
        //    {
        //        button1.Text = "X";
        //        player++;
        //    }
        //    else if (player == 1)
        //    {
        //        button1.Text = "O";
        //        player--;
        //    }
        //    button1.Enabled = false;

        //    win();

        //}
        
        //void win()
        //{
        //    if(button1.Text != "" && button2.Text != "" && button3.Text != ""
        //        && button4.Text != "" && button5.Text != "" && button6.Text != ""
        //        && button7.Text != "" && button8.Text != "" && button9.Text != "")
        //    {
        //        winnerTxt.Text = "Draw";
        //    }
        //    //Check if X wins
        //    if (button1.Text != "X" && button2.Text != "X" && button3.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button4.Text != "X" && button5.Text != "X" && button6.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button7.Text != "X" && button8.Text != "X" && button9.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button1.Text != "X" && button4.Text != "X" && button7.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button2.Text != "X" && button5.Text != "X" && button8.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button3.Text != "X" && button6.Text != "X" && button9.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button2.Text != "X" && button5.Text != "X" && button8.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button1.Text != "X" && button5.Text != "X" && button9.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button3.Text != "X" && button5.Text != "X" && button7.Text != "X")
        //    {
        //        winnerTxt.Text = "X won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }

        //    //Check if O wins
        //    if (button1.Text != "O" && button2.Text != "O" && button3.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button4.Text != "O" && button5.Text != "O" && button6.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button7.Text != "O" && button8.Text != "O" && button9.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button1.Text != "O" && button4.Text != "O" && button7.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button2.Text != "O" && button5.Text != "O" && button8.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button3.Text != "O" && button6.Text != "O" && button9.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button2.Text != "O" && button5.Text != "O" && button8.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button1.Text != "O" && button5.Text != "O" && button9.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //    if (button3.Text != "O" && button5.Text != "O" && button7.Text != "O")
        //    {
        //        winnerTxt.Text = "O won";
        //        button1.Enabled = false;
        //        button2.Enabled = false;
        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //        button5.Enabled = false;
        //        button6.Enabled = false;
        //        button7.Enabled = false;
        //        button8.Enabled = false;
        //        button9.Enabled = false;
        //    }
        //}
  