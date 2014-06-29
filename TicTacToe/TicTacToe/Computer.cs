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
    class Computer
    {
        bool moveMade;
        Random rand = new Random();
        public int computer;
        public Image token;
        public int otherPlayer;
        bool firstMove = true;
        int numOnBoard=0;
        public int[,] Code(int[,] coordinate)
        {
            moveMade = false;
            WinningMove(coordinate);
            DefensiveMove(coordinate);
            Strategy(coordinate);
            return coordinate;
        }
        public void Init(Image TOKEN)
        {
            token = TOKEN;
            computer = 1;
        }
        private void MakeMove(int[,] coordinate, int i, int j)
        {
            if (!moveMade)
            {
                if (coordinate[i, j] == 5)
                {
                    coordinate[i, j] = computer;
                    moveMade = true;
                    numOnBoard++;
                }
            }
        }


        private void WinningMove(int [,] coordinate)
        {
            HorizontalTwoCheck(coordinate, computer);
            HorizontalGapCheck(coordinate, computer);
            VerticalTwoCheck(coordinate, computer);
            VerticalGapCheck(coordinate, computer);
            DiagonalWinCheck(coordinate, computer);
        }
        private void DefensiveMove(int[,] coordinate)
        {
            HorizontalTwoCheck(coordinate, otherPlayer);
            HorizontalGapCheck(coordinate, otherPlayer);
            VerticalTwoCheck(coordinate, otherPlayer);
            VerticalGapCheck(coordinate, otherPlayer);
            DiagonalWinCheck(coordinate, otherPlayer);
        }

        private void HorizontalTwoCheck(int [,] coordinate, int player)
        {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (coordinate[i, j] == player)
                            if (coordinate[i + 1, j] == player)
                            {
                                int iLoc = i + 2;
                                if (iLoc > 2)
                                    iLoc = iLoc - 3;
                                MakeMove(coordinate, iLoc, j);
                            }
                    }
                }
        }//checked
        private void HorizontalGapCheck(int[,] coordinate, int player)
        {
            for (int j = 0; j < 3; j++)
            {
                if (coordinate[0, j] == player)
                    if (coordinate[2, j] == player)
                       {
                           MakeMove(coordinate, 1, j);
                       }
            }
        }//checked
        private void VerticalTwoCheck(int[,] coordinate, int player)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (coordinate[i, j] == player)
                        if (coordinate[i, j + 1] == player)
                        {
                            int jLoc = j + 2;
                            if (jLoc > 2)
                                jLoc = jLoc - 3;
                            MakeMove(coordinate, i, jLoc);
                        }
                }
            }

        }//checked
        private void VerticalGapCheck(int[,] coordinate, int player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (coordinate[i,0] == player)
                    if (coordinate[i,2] == player)
                    {
                        MakeMove(coordinate, i, 1);
                    }
            }
        }//checked
        private void DiagonalWinCheck(int[,] coordinate, int player)
        {
            if (coordinate[1, 1] == player)
            {
                if (coordinate[2, 0] == player)
                    MakeMove(coordinate, 0, 2);
                if (coordinate[0, 2] == player)
                   MakeMove(coordinate,2,0);

                if (coordinate[0, 0] == player)
                    MakeMove(coordinate, 2, 2);
                if (coordinate[2, 2] == player)
                    MakeMove(coordinate, 0, 0);
            }
            if (coordinate[0, 0] == player)
                if (coordinate[2, 2] == player)
                    MakeMove(coordinate, 1, 1);
            if (coordinate[0, 2] == player)
                if (coordinate[2, 0] == player)
                    MakeMove(coordinate, 1, 1);
        }//checked

        private void Strategy(int[,] coordinate)
        {
            FirstMove(coordinate);
            if (firstMove)
                WentFirst(coordinate);
            else
                WentSecond(coordinate);
            while (!moveMade)
            {
                int i = rand.Next(0, 3);
                int j = rand.Next(0, 3);
                MakeMove(coordinate, i, j);
            }
            
            
        }
        private void FirstMove(int[,] coordinate)
        {
            if (numOnBoard == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (coordinate[i, j] != 5)
                            firstMove = false;
                    }
                }
                if (firstMove)
                {
                    int move = rand.Next(0, 4);
                    switch (move)
                    {
                        case 0:
                            MakeMove(coordinate, 0, 0);
                            break;
                        case 1:
                            MakeMove(coordinate, 0, 2);
                            break;
                        case 2:
                            MakeMove(coordinate, 2, 0);
                            break;
                        case 3:
                            MakeMove(coordinate, 2, 2);
                            break;
                    }
                }
            }
        }//checked

        private void WentFirst(int[,] coordinate)
        {
            switch (numOnBoard)
            {
                case 1:
                    SecondMove1st(coordinate);
                    break;
                case 3:
                    ThirdMove1st(coordinate);
                    break;
            }
            
        }
        private void WentSecond(int[,] coordinate)
        {
           switch (numOnBoard)
           {
               case 0:
                   FirstMove2nd(coordinate);
                   break;
               case 1:
                   SecondMove2nd(coordinate);
                   break;
           }
        }

        private void SecondMove1st(int[,] coordinate)
        {
            if (coordinate[1, 1] == otherPlayer)
            {
                SecondMove1stCenter(coordinate);
            }
            else
            {
                SecondMove1stNotCenter(coordinate);
            }
        }//checked
        private void SecondMove1stNotCenter(int [,] coordinate)
        {
            int iLoc=0;
            int jLoc=0;
            int oILoc=0;
            int oJLoc=0;
            for (int i = 0; i < 3; i++)
               {
                  for (int j = 0; j < 3; j++)
                    {
                       if (coordinate[i, j] == computer)
                          {
                             iLoc = i;
                             jLoc = j;
                          }
                       if (coordinate[i, j] == otherPlayer)
                       {
                           oILoc = i;
                           oJLoc = j;
                       }
                     }
                }
            if (iLoc != oILoc)
            {
                switch (iLoc)
                {
                    case 0:
                        if (jLoc == 0)
                        {
                            MakeMove(coordinate, 0, 2);
                        }
                        else
                        { MakeMove(coordinate, 0, 0); }
                        break;
                    case 2:
                        if (jLoc == 0)
                        {
                            MakeMove(coordinate, 2, 2);
                        }
                        else
                        { MakeMove(coordinate, 2, 0); }
                        break;
                }
            }
            else
            {
                switch (jLoc)
                {
                    case 0:
                        if (iLoc == 0)
                        {
                            MakeMove(coordinate, 2, 0);
                        }
                        else
                        { MakeMove(coordinate, 0, 0); }
                        break;
                    case 2:
                        if (iLoc == 0)
                        {
                            MakeMove(coordinate, 2, 2);
                        }
                        else
                        { MakeMove(coordinate, 0, 2); }
                        break;
                }
            }
    
        }//checked
        private void SecondMove1stCenter(int[,] coordinate)
        {
            int jLoc=0;
            int iLoc=0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (coordinate[i, j] == computer)
                    {
                        iLoc = i;
                        jLoc = j;
                    }
                }

            }
            int newJLoc = Math.Abs(jLoc - 2);
            int newILoc = Math.Abs(iLoc - 2);
            MakeMove(coordinate, newILoc, newJLoc);

        } //checked

        private void ThirdMove1st(int[,] coordinate)
        {
            int[] iLoc = new int[3];
            int[] jLoc = new int[3];
            int[] oJLoc = new int[3];
            int[] oILoc = new int[3];
            int [] n = {0,0};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (coordinate[i, j] == computer)
                    {
                        iLoc[n[0]] = i;
                        jLoc[n[0]] = j;
                        n[0]++;
                    }
                    if (coordinate[i, j] == otherPlayer)
                    {
                        oJLoc[n[1]] = j;
                        oILoc[n[1]] = i;
                        n[1]++;
                    }
                }
            }

            if (iLoc[0] == iLoc[1])
            {int newJLoc =0;
                if (jLoc[0] != oJLoc[0] && jLoc[0] != oJLoc[1])
                {
                    newJLoc = jLoc[0];
                }
                else
                {
                     newJLoc = jLoc[1];
                }
                int newILoc = Math.Abs(iLoc[0] - 2);
                MakeMove(coordinate, newILoc, newJLoc);
            }
            else if (jLoc[0] == jLoc[1])
            {
                int newILoc = 0;
                if (iLoc[0] != oILoc[0] && iLoc[0] != oILoc[1])
                {
                    newILoc = iLoc[0];
                }
                else
                {
                    newILoc = iLoc[1];
                }
                int newJLoc = Math.Abs(jLoc[0] - 2);
                MakeMove(coordinate, newILoc, newJLoc);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (iLoc[i] != oILoc[0] && iLoc[i] != oILoc[1])
                    {
                        int newJLoc = Math.Abs(jLoc[0] - 2);
                        MakeMove(coordinate, iLoc[i], newJLoc);

                    }
                    if (jLoc[i] != oJLoc[0] && jLoc[i] != oJLoc[1])
                    {
                        int newILoc = Math.Abs(iLoc[0] - 2);
                        MakeMove(coordinate, newILoc,jLoc[i]);

                    }
                }
            }

            

        }



        private void FirstMove2nd(int[,] coordinate)
        {
            
                    if (coordinate[1, 1] == otherPlayer)
                    {
                        int move = rand.Next(0, 4);
                        switch (move)
                        {
                            case 0:
                                MakeMove(coordinate, 0, 0);
                                break;
                            case 1:
                                MakeMove(coordinate, 0, 2);
                                break;
                            case 2:
                                MakeMove(coordinate, 2, 0);
                                break;
                            case 3:
                                MakeMove(coordinate, 2, 2);
                                break;
                        }
                    }
                    else
                    {
                        MakeMove(coordinate, 1, 1);
                    }
                }

        private void SecondMove2nd(int[,] coordinate)
        {
            if (coordinate[1, 1] == computer)
                SecondMove2ndCenter(coordinate);
            else
                SecondMoveNotCenter(coordinate);
        }
        private void SecondMove2ndCenter(int[,] coordinate)
        {
            if ((coordinate[0, 0] == otherPlayer && coordinate[2, 2] == otherPlayer) || 
                (coordinate[2, 0] == otherPlayer && coordinate[0, 2] == otherPlayer))
            {
                int move = rand.Next(0, 4);
                switch (move)
                {
                    case 0:
                        MakeMove(coordinate,1, 0);
                        break;
                    case 1:
                        MakeMove(coordinate, 1, 2);
                        break;
                    case 2:
                        MakeMove(coordinate, 0,1);
                        break;
                    case 3:
                        MakeMove(coordinate, 2,1);
                        break;
                }
            }
        }
        private void SecondMoveNotCenter(int [,] coordinate)
        {
            int[] oJLoc = new int[3];
            int[] oILoc = new int[3];
            int iLoc = 0;
            int jLoc = 0;
            int n = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (coordinate[i, j] == otherPlayer)
                    {
                        oJLoc[n] = j;
                        oILoc[n] = i;
                        n++;
                    }
                    if (coordinate[i, j] == computer)
                    {
                        iLoc = i;
                        jLoc = j;
                        n++;
                    }
                }
            }

            if (oJLoc[0] != oJLoc[1] && oILoc[0] != oILoc[1])
            {
                while (!moveMade)
                {
                    int move = rand.Next(0, 4);
                    switch (move)
                    {
                        case 0:
                            MakeMove(coordinate, 0, 0);
                            break;
                        case 1:
                            MakeMove(coordinate, 0,2);
                            break;
                        case 2:
                            MakeMove(coordinate, 2, 0);
                            break;
                        case 3:
                            MakeMove(coordinate, 2, 2);
                            break;
                    }
                }
            }
        }

    }
}
    