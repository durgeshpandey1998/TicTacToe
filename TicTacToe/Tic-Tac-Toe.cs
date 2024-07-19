using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        // Define a 2D array of buttons to represent the game board.
        Button[,] btns = new Button[4, 4];

        // Initialize the game board.
        public void initialise()
        {
            // Assign each button in the 2D array to its corresponding button on the form.
            btns[1, 1] = btn1;
            btns[1, 2] = btn2;
            btns[1, 3] = btn3;
            btns[2, 1] = btn4;
            btns[2, 2] = btn5;
            btns[2, 3] = btn6;
            btns[3, 1] = btn7;
            btns[3, 2] = btn8;
            btns[3, 3] = btn9;
        }

        // Constructor for the TicTacToe class.
        public TicTacToe()
        {
            InitializeComponent();
            initialise();
        }

        // Variables to keep track of game state.
        int round_count = 1;
        int btn_count = 1;
        string symbol;
        int win_count_O = 0;
        int win_count_X = 0;
        int flag = 0;

        // Determine which player's turn it is.
        private void turn_decider()
        {
            if (btn_count % 2 == 0)
            {
                symbol = "O";// even number represents 'O'.
            }
            else
            {
                symbol = "X";// odd number represents 'X'.
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            initialise();
        }

        // Event handlers for each button on the game board
        private void btn1_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn1.Text = symbol;
            btn_count++;
            btn1.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(1, 1);

            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn2.Text = symbol;
            btn_count++;
            btn2.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(1, 2);
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn3.Text = symbol;
            btn_count++;
            btn3.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(1, 3);
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn4.Text = symbol;
            btn_count++;
            btn4.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(2, 1);
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn5.Text = symbol;
            btn_count++;
            btn5.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(2, 2);
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn6.Text = symbol;
            btn_count++;
            btn6.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(2, 3);
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn7.Text = symbol;
            btn_count++;
            btn7.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(3, 1);
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn8.Text = symbol;
            btn_count++;
            btn8.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(3, 2);
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            turn_decider();
            btn9.Text = symbol;
            btn_count++;
            btn9.Enabled = false;
            if (btn_count >= 5)
            {
                check_winner(3, 3);
            }
        }

        //Checks the winner for every single round.
        public void check_winner(int row, int col)
        {
            if (btns[row, col].Text == "O")
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (btns[i, 1].Text == "O" && btns[i, 2].Text == "O" && btns[i, 3].Text == "O")
                    {
                        MessageBox.Show("O is the Winner of this round ");
                        win_count_O++;
                        necessary_calculations();
                        clear();
                    }
                    if (btns[1, i].Text == "O" && btns[2, i].Text == "O" && btns[3, i].Text == "O")
                    {
                        MessageBox.Show("O is the Winner of this round ");
                        win_count_O++;
                        necessary_calculations();
                        clear();
                    }
                }
                if (btns[1, 1].Text == "O" && btns[2, 2].Text == "O" && btns[3, 3].Text == "O")
                {
                    MessageBox.Show("O is the Winner of this round ");
                    win_count_O++;
                    necessary_calculations();
                    clear();
                }
                if (btns[1, 3].Text == "O" && btns[2, 2].Text == "O" && btns[3, 1].Text == "O")
                {
                    MessageBox.Show("O is the Winner of this round ");
                    win_count_O++;
                    necessary_calculations();
                    clear();
                }
            }
            if (btns[row, col].Text == "X")
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (btns[i, 1].Text == "X" && btns[i, 2].Text == "X" && btns[i, 3].Text == "X")
                    {
                        MessageBox.Show("X is the Winner of this round ");
                        win_count_X++;
                        necessary_calculations();
                        clear();
                    }
                    if (btns[1, i].Text == "X" && btns[2, i].Text == "X" && btns[3, i].Text == "X")
                    {
                        MessageBox.Show("X is the Winner of this round ");
                        win_count_X++;
                        necessary_calculations();
                        clear();
                    }
                }
                if (btns[1, 1].Text == "X" && btns[2, 2].Text == "X" && btns[3, 3].Text == "X")
                {
                    MessageBox.Show("X is the Winner of this round ");
                    win_count_X++;
                    necessary_calculations();
                    clear();
                }
                if (btns[1, 3].Text == "X" && btns[2, 2].Text == "X" && btns[3, 1].Text == "X")
                {
                    MessageBox.Show("X is the Winner of this round ");
                    win_count_X++;
                    necessary_calculations();
                    clear();
                }
                if (btn_count > 9)
                {
                    MessageBox.Show("This round is a draw. ");
                    necessary_calculations();
                    clear();
                }
            }
        }

        //Makes necessary calculations and performs decisions to determine wether there is a draw or win.
        public void necessary_calculations()
        {
            if (round_count >= 3)
            {
                check_finalWinner();
            }

            round_count++;

            if (round_count > 5 && (win_count_O == win_count_X))
            {
                //Generates a super round if there is a draw after 5 rounds
                if (flag == 1)
                {
                    DialogResult ok = MessageBox.Show("The super round is also a draw. \nTry again next time.", "DRAW", MessageBoxButtons.OK);
                    MessageBox.Show("GAME OVER \n☺ THANKS FOR PLAYING ☺");
                    if (ok == DialogResult.OK)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else
                {
                    DialogResult ok = MessageBox.Show("Both the players has same score. \nFinal result will be decided by playing a super round", "DRAW", MessageBoxButtons.OK);
                    string draw = "0";
                    round_no.Text = draw.ToString();
                    flag = 1;
                }
            }
            else
            {
                round_no.Text = round_count.ToString();
            }

            btn_count = 1;
            score_X.Text = win_count_X.ToString();
            score_O.Text = win_count_O.ToString();
        }

        //Clears the the game board after every round
        public void clear()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    btns[i, j].Text = " ";
                    btns[i, j].Enabled = true;
                }
            }
        }

        //Determines the final winner of 5 rounds.
        public void check_finalWinner()
        {
            if (win_count_X >= 3 || (flag == 1 && win_count_X > win_count_O))
            {
                DialogResult ok = MessageBox.Show("X IS THE FINAL CHAMPION.", "FINAL RESULT", MessageBoxButtons.OK);
                MessageBox.Show("GAME OVER \n☺ THANKS FOR PLAYING ☺");
                if (ok == DialogResult.OK)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else if (win_count_O >= 3 || (flag == 1 && win_count_O > win_count_X))
            {
                DialogResult ok = MessageBox.Show("O IS THE FINAL CHAMPION.", "FINAL RESULT", MessageBoxButtons.OK);
                MessageBox.Show("GAME OVER \n☺ THANKS FOR PLAYING ☺");
                if (ok == DialogResult.OK)
                {
                    System.Windows.Forms.Application.Exit();
                }   
            }
        }
    }
}
