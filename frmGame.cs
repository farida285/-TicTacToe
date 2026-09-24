using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static TicTacToe.clsGame;

namespace TicTacToe
{
    public partial class frmGame : Form
    {

        private clsGame game ;
        public frmGame(string p1, string p2)
        {
            InitializeComponent();
            game=new clsGame(p1, p2);
            StartPosition = FormStartPosition.CenterScreen;
          

        }


        private void frmGame_Load(object sender, EventArgs e)
        {
            lbWinner.BackColor = Color.Transparent;
            lbTurn.BackColor = Color.Transparent;
            gpCards.BackColor = Color.Transparent;
            lbTurn.Text = (game.Turn == clsGame.enPlayer.Player1) ? game.NameOfPlayers[0]:game.NameOfPlayers[1];
            pbTurn.Image = (game.Turn == clsGame.enPlayer.Player1) ? Resources.XImage : Resources.OImage;
            lbWinner.Text = "";
            lbTurn.ForeColor = Color.Indigo;
            lbWinner.ForeColor = Color.Indigo;
        }

  
        
        private void  UpdateGameForm()
        {

            if (game.finishRound)
            {
                lbTurn.Text = "Game Over";
                lbWinner.Text = game.StringOfWhoIsWinner();
                foreach (Control c in gpCards.Controls)
                {
                    if (c is Button)
                    {
                        Button btn = (Button)c;
                        btn.Enabled = false;
                    }
                }
            }
            else
            {
                lbTurn.Text = (game.Turn == clsGame.enPlayer.Player1) ? game.NameOfPlayers[0] : game.NameOfPlayers[1];
                pbTurn.Image = (game.Turn == clsGame.enPlayer.Player1) ? Resources.XImage : Resources.OImage;
               
            }
                  

        }

     
        private void Button_Click(object sender, EventArgs e)
        {
            clsGame.enPlayer lasttemp = game.Turn;
            if (game.Play((string)((Button)sender).Tag))
            {
                if (lasttemp == clsGame.enPlayer.Player1)
                {
                    ((Button)sender).BackgroundImage = Resources.XImage;
                }
                else if (lasttemp == clsGame.enPlayer.Player2)
                {
                    ((Button)sender).BackgroundImage = Resources.OImage;
                }
                ((Button)sender).Enabled = false;
                UpdateGameForm();
            }
        }
        private void btRestart_Click(object sender, EventArgs e)
        {
            foreach (Control c in gpCards.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.BackgroundImage = Resources.QuesImage2;
                    btn.Enabled = true;
                }
            }
            game.RestartGame();
            pbTurn.Image = (game.Turn == clsGame.enPlayer.Player1) ? Resources.XImage : Resources.OImage;
            lbTurn.Text = (game.Turn == clsGame.enPlayer.Player1) ? game.NameOfPlayers[0] : game.NameOfPlayers[1];
            lbWinner.Text = "";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
