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
    public partial class Form1 : Form
    {
        int turn =0;
        bool[] used = new bool[]{true,true,true,true,true,true,true,true,true};
        int[,] coordinate = new int[3, 3] { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } };
        Computer computer = new Computer();
        PictureBox[,] board = new PictureBox[3,3];
        Random rand = new Random();
        bool gameOver= false;
        Image playerToken;
        int player;
        int oWins = 0;
        int xWins = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pb0_Click(object sender, EventArgs e)
        {
            if (used[0] == false)
            {
                if (turn != computer.computer)
                {
                    pb0.Image = playerToken;
                    turn = computer.computer;
                    used[0] = true;
                    coordinate[0, 0] = player;
                    WinCheck(player);
                }
                TurnManagement();
            }
        }
        private void pb1_Click(object sender, EventArgs e)
        {
            if (used[1] == false)
            {
                if (turn != computer.computer)
                {
                    pb1.Image = playerToken;
                    turn = computer.computer;
                    used[1] = true;
                    coordinate[1,0] = player;
                    WinCheck(player);
                    TurnManagement();
                }
            }
        }
        private void pb2_Click(object sender, EventArgs e)
        {
            if (used[2] == false)
            {
                if (turn != computer.computer)
                {
                    pb2.Image = playerToken;
                    turn = computer.computer;
                    used[2] = true;
                    coordinate[2,0] = player;
                    WinCheck(player);
                    TurnManagement();
                }
            }
        }
        private void pb3_Click(object sender, EventArgs e)
        {
            if (used[3] == false)
            {
                if (turn != computer.computer)
                {
                    pb3.Image = playerToken;
                    turn = computer.computer;
                    used[3] = true;
                    coordinate[0,1] = player;
                    WinCheck(player);
                    TurnManagement();
                }
            }
        }
        private void pb4_Click(object sender, EventArgs e)
        {
            if (used[4] == false)
            {
                if (turn != computer.computer)
                {
                    pb4.Image = playerToken;
                    turn = computer.computer;
                    used[4] = true;
                    coordinate[1, 1] = player;
                    WinCheck(player);
                    TurnManagement();
                }
            }
        }
        private void pb5_Click(object sender, EventArgs e)
        {
            if (used[5] == false)
            {
                if (turn != computer.computer)
                {
                    pb5.Image = playerToken;
                    turn = computer.computer;
                    used[5] = true;
                    coordinate[2,1] = player;
                    WinCheck(player);
                    TurnManagement();
                }
            }
        }
        private void pb6_Click(object sender, EventArgs e)
        {
            if (used[6] == false)
            {
                if (turn != computer.computer)
                {
                    pb6.Image = playerToken;
                    turn = computer.computer;
                    used[6] = true;
                    coordinate[0,2] = player;
                    WinCheck(player);
                    TurnManagement();
                }
            }
        }
        private void pb7_Click(object sender, EventArgs e)
        {
            if (used[7] == false)
            {
                if (turn != computer.computer)
                {
                    pb7.Image = playerToken;
                    turn = computer.computer;
                    used[7] = true;
                    coordinate[1,2] = player;
                    WinCheck(player);
                    TurnManagement();
                }
            }
        }
        private void pb8_Click(object sender, EventArgs e)
        {
            if (used[8] == false)
            {
                if (turn != computer.computer)
                {
                    pb8.Image = playerToken;
                    turn = computer.computer;
                    used[8] = true;
                    coordinate[2, 2] = player;
                    WinCheck(player);
                    TurnManagement();
                }

            }
        }

        private void BoardManagement()
        {
            if (coordinate[0, 0] == computer.computer)
            {
                pb0.Image = computer.token;
                used[0] = true;
            }
            if (coordinate[1,0] == computer.computer)
            {
                pb1.Image = computer.token;
                used[1] = true;
            }
            if (coordinate[2,0] == computer.computer)
            {
                pb2.Image = computer.token;
                used[2] = true;
            }
            if (coordinate[0,1] == computer.computer)
            {
                pb3.Image = computer.token;
                used[3] = true;
            }
            if (coordinate[1, 1] == computer.computer)
            {
                pb4.Image = computer.token;
                used[4] = true;
            }
            if (coordinate[2,1] == computer.computer)
            {
                pb5.Image = computer.token;
                used[5] = true;
            }
            if (coordinate[0,2] == computer.computer)
            {
                pb6.Image = computer.token;
                used[6] = true;
            }
            if (coordinate[1,2] == computer.computer)
            {
                pb7.Image = computer.token;
                used[7] = true;
            }
            if (coordinate[2, 2] == computer.computer)
            {
                pb8.Image = computer.token;
                used[8] = true;
            }
            turn = computer.otherPlayer;
            WinCheck(computer.computer);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pb0.Image = null;
            pb1.Image = null;
            pb2.Image = null;
            pb3.Image = null;
            pb4.Image = null;
            pb5.Image = null;
            pb6.Image = null;
            pb7.Image = null;
            pb8.Image = null;
            for (int i = 0; i < 9; i++)
            {
                used[i] = false;
                
            }
            lblAnounce.Text = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    coordinate[i, j] = 5;
                }
            }
            computer = new Computer();
            turn = rand.Next(0,2);
                      
            computer.Init(oPic.Image);
            playerToken = xPic.Image;
              
            
            gameOver = false;
            TurnManagement();
        }

        private void TurnManagement()
        {
            if (turn != player)
            {
                if(!gameOver)
                computer.Code(coordinate);
                turn = player;
                BoardManagement();
            }
            if (turn == 0)
            {
                xPic.BackColor = Color.Yellow;
                oPic.BackColor = Color.White;
            }
            if (turn == 1)
            {
                xPic.BackColor = Color.White;
                oPic.BackColor = Color.Yellow;
            }
            
        }

        private void WinCheck(int player)
        {
            bool tie = true;
            for (int i = 0; i < 9; i++)
            {
                if (used[i] == false)
                    tie = false;
            }
            if (tie == true)
            {
                lblAnounce.Text = "IT'S A TIE";
                gameOver = true;
            }
            for (int i = 0; i < 3; i++)
            {
                if (coordinate[i, 0] == player)
                    if (coordinate[i, 1] == player)
                        if (coordinate[i, 2] == player)
                            Win(player);
                if (coordinate[0, i] == player)
                    if (coordinate[1, i] == player)
                        if (coordinate[2, i] == player)
                            Win(player);
                if (coordinate[1, 1] == player)
                {
                    if (coordinate[0, 0] == player)
                        if (coordinate[2, 2] == player)
                            Win(player);
                    if (coordinate[2, 0] == player)
                        if (coordinate[0, 2] == player)
                            Win(player);
                }
              
            }
           
                
        }
        private void Win(int player)
        {
            for (int i = 0; i < 9; i++)
            {
                used[i] = true;
            }
            if (gameOver == false)
            {
                switch (player)
                {
                    case 0:
                        lblAnounce.Text = "X WINS!";
                        xWins++;
                        lblXWins.Text = xWins.ToString();
                        break;
                    case 1:
                        lblAnounce.Text = "O WINS!";
                        oWins++;
                        lblOWins.Text = oWins.ToString();
                        break;
                }
            }
            gameOver = true;
        }


    }
}
