using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class clsGame
    {
        public enum enPlayer { noOne, Player1, Player2 };
        public enum enWinner { notSelected, Player1, Player2, Draw }; 
        public enWinner  winner { get; private set; } = enWinner.notSelected;
       public string[] NameOfPlayers { get; private set; } = new string[2] { "Player1", "Player2" };

        private struct stGamePoint
        {
            public enPlayer value;
            public bool Locked ;
        }

        private stGamePoint [,] game = new stGamePoint[3,3];

        public bool finishRound=false ;
        public enPlayer Turn { get; private set; } = enPlayer.Player1;

        public clsGame() { 
        }
        public clsGame(string player1,string player2) {

            if (!((string.IsNullOrEmpty(player1)) || player1.Length > 10))
            {
                NameOfPlayers[0]=player1;
            }
            if (!(player2 == player1||(string.IsNullOrEmpty(player2)) || player2.Length > 10 ))
            {
                NameOfPlayers[1]=player2;
            }

        }

        private void DefineIndex(string NumberOfPlace, out byte index1, out byte index2)
        {
            Byte firstDigit = Convert.ToByte(NumberOfPlace.Substring(0,1));
            Byte lastDigit = Convert.ToByte(NumberOfPlace.Substring(1, 1));
            index1 = firstDigit;
            index2 = lastDigit;
        }
        private bool ChoosePlace(int index1, int index2)
        {

            if (Turn == enPlayer.noOne)
            {
                return false;
            }
            else if(!game[index1, index2].Locked)
            {
                game[index1, index2].value = Turn;
                game[index1, index2].Locked = true;
     
                return true;
            }
            return false;

        }
        private void SwitchTurn()

        {
            
      
            if (Turn == enPlayer.Player1)
            {
                Turn = enPlayer.Player2;
            }
            else if (Turn == enPlayer.Player2)
            {
                Turn = enPlayer.Player1;
            }
         
        }
        private bool CheckLine(enPlayer a, enPlayer b, enPlayer c)
        {
            if (a != enPlayer.noOne && a == b && b == c)
            {
                winner = (a == enPlayer.Player1) ? enWinner.Player1 : enWinner.Player2;
                return true;
            }
            return false;
        }
        private bool IsAllgamePointLocked()
        {

            foreach (stGamePoint p in game)
            {
                if (p.Locked == false)
                {
                    return false;
                }
            }
            return true;
        }
        private enWinner WhoIsWinner()

        {
            if (game[0, 0].Locked|| game[0, 2].Locked|| game[2, 0].Locked|| game[1,1 ].Locked)
            {
                if (game[0, 0].Locked)
                {
                    if (CheckLine(game[0, 0].value, game[0, 1].value, game[0, 2].value)) return winner;
                    if (CheckLine(game[0, 0].value, game[1, 0].value, game[2, 0].value)) return winner;
                    if (CheckLine(game[0, 0].value, game[1, 1].value, game[2, 2].value)) return winner;

                }
                if (game[0, 2].Locked)
                {
                    if (game[0, 2].value == game[1, 2].value && game[1, 2].value == game[2, 2].value)
                    {
                        if (game[0, 2].value == enPlayer.Player1)
                        {
                            return enWinner.Player1;
                        }
                        else
                        {
                            return enWinner.Player2;
                        }
                    }
                    if (game[0, 2].value == game[1, 1].value && game[1, 1].value == game[2, 0].value)
                    {
                        if (game[0, 2].value == enPlayer.Player1)
                        {
                            return enWinner.Player1;
                        }
                        else
                        {
                            return enWinner.Player2;
                        }

                    }
                }
                
                if (game[2, 0].Locked)
                {
                    if (game[2, 0].value == game[2, 1].value && game[2, 1].value == game[2, 2].value)
                    {
                        if (game[2,0].value == enPlayer.Player1)
                        {
                            return enWinner.Player1;
                        }
                        else
                        {
                            return enWinner.Player2;
                        }
                    }

                }
                if (game[1,1].Locked)
                {
                    if (game[1, 0].value == game[1, 1].value && game[1, 1].value == game[1, 2].value)
                    {
                        if (game[1, 1].value == enPlayer.Player1)
                        {
                            return enWinner.Player1;
                        }
                        else
                        {
                            return enWinner.Player2;
                        }
                    }
                    if (game[0, 1].value == game[1, 1].value && game[1, 1].value == game[2, 1].value)
                    {
                        if (game[1, 1].value == enPlayer.Player1)
                        {
                            return enWinner.Player1;
                        }
                        else
                        {
                            return enWinner.Player2;
                        }

                    }
                }

            } 
            if (IsAllgamePointLocked())
            {
                return enWinner.Draw;

            }
            else
            {
                return enWinner.notSelected;
            }

           
        }

        private void IfFinishedLookGame()
        {
            if (winner != enWinner.notSelected)
            {
                finishRound = true;
                Turn = enPlayer.noOne;
            }
        }

        public bool Play(string NumberOfPlace)
        {
            if (!finishRound && Turn != enPlayer.noOne) {
                byte index1;
                byte index2;

                DefineIndex(NumberOfPlace, out index1, out index2);

                if (ChoosePlace(index1, index2) )

                {
                    SwitchTurn();
                    winner =WhoIsWinner();
                    IfFinishedLookGame();
                    return true;

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
           
        }

       public string StringOfWhoIsWinner()
        {
            if (finishRound)
            {
                if (winner == enWinner.Draw)
                {
                    return "Draw";
                }
                else if (winner == enWinner.Player1)
                {
                    return NameOfPlayers[0];
                }
                else if (winner == enWinner.Player2)
                {
                    return NameOfPlayers[1];
                }
            }  
                return "Not Selected";
            
        }
    
        public void RestartGame()
        {
            finishRound = false;
            winner = enWinner.notSelected;
            game= new stGamePoint[3, 3];
            Turn = enPlayer.Player1;
        }
    }
}


