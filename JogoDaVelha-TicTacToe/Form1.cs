using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha_TicTacToe
{
    public partial class Form1 : Form
    {
        static public Button[] gridButtons = new Button[] { };
        static public char[] players = new char[] { 'O', 'X' };
        static public char actualPlayer;
        static public bool gameStarted = false, gameOver = false, velha;


        static Random rnd = new Random();
        static int startingPlayerIndex = 0;


        public Form1()
        {
            InitializeComponent();
            gridButtons = new Button[]
            {button00, button01, button02,
             button03, button04, button05,
             button06, button07,button08};
            gameStarted = false;
        }

        private void StartOrRestartGame()
        {
            gameStarted = true;
            startingPlayerIndex = rnd.Next(1000) % 2 == 0 ? 0 : 1;
            actualPlayer = players[startingPlayerIndex];
            gameLog.Text = "Sua vez: " + actualPlayer;
            foreach (var button in gridButtons)
            {
                button.Text = "-";
            }
        }

        //Testa a matriz :
        // 0 1 2
        // 3 4 5
        // 6 7 8
        private bool VerifyGridForWinners()
        {
            //o o o
            //o o -
            //o - o
            if (gridButtons[0].Text == gridButtons[1].Text && gridButtons[1].Text == gridButtons[2].Text||
                gridButtons[0].Text == gridButtons[3].Text && gridButtons[3].Text == gridButtons[6].Text||
                gridButtons[0].Text == gridButtons[4].Text && gridButtons[4].Text == gridButtons[8].Text)
                        if (gridButtons[0].Text != "-")
                            return true;
            //- o -
            //- o -
            //- o -
            if (gridButtons[1].Text == gridButtons[4].Text && gridButtons[4].Text == gridButtons[7].Text)
                if (gridButtons[1].Text != "-")
                    return true;

            //- - o
            //- o o
            //o - o
            if (gridButtons[2].Text == gridButtons[5].Text && gridButtons[5].Text == gridButtons[8].Text ||
                gridButtons[2].Text == gridButtons[4].Text && gridButtons[4].Text == gridButtons[6].Text)
                if (gridButtons[2].Text != "-")
                    return true;

            //- - -
            //o o o
            //- - -
            if (gridButtons[3].Text == gridButtons[4].Text && gridButtons[4].Text == gridButtons[5].Text)
                if (gridButtons[3].Text != "-")
                    return true;

            //- - -
            //- - -
            //o o o
            if (gridButtons[6].Text == gridButtons[7].Text && gridButtons[7].Text == gridButtons[8].Text)
                if (gridButtons[6].Text != "-")
                    return true;

            return false;
        }

        private void GridButton_Clicked(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                if ((Button)sender == null)
                    return;

                if (((Button)sender).Text == "-")
                    ((Button)sender).Text = actualPlayer.ToString();

                if (VerifyGridForWinners())
                {
                    gameLog.BackColor = Color.Green;
                    gameLog.Text = "O ganhador foi " + actualPlayer + "!";
                    gameStarted = false;
                    gameButton.Text = "Novo Jogo";
                }
                else
                {

                    velha = true;
                    foreach (var button in gridButtons)
                    {
                        if (button.Text == "-")
                            velha = false;
                    }

                    if (velha)
                    {
                        gameLog.BackColor = Color.Gray;
                        gameLog.Text = "Ih deu velha!";
                        gameStarted = false;
                        gameButton.Text = "Novo Jogo";
                    }
                    else
                    {
                        if (actualPlayer == players[0])
                            actualPlayer = players[1];
                        else
                            actualPlayer = players[0];
                        gameLog.Text = "Sua vez: " + actualPlayer;
                    }
                }
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            gameButton.Text = "Recomeçar";
            StartOrRestartGame();
        }
    }
}
