using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Player
    {
        public string name = "";
        public string character = "";
        private static Form1 mainGame;
        public Player(string _name, string _character, Form1 _mainGame)
        {
            name = _name;
            character = _character;
            mainGame = _mainGame;
        }

        private static Button ChoseRandom()
        {
            Random rand = new Random();
            Button chosen = mainGame.remainingButtons[rand.Next(0, mainGame.remainingButtons.Count())];
            return chosen;
        }

        private static Button CheckForPlayer2Win()
        {
            List<Button> remaining = new List<Button>(mainGame.remainingButtons);
            foreach (Button btn in remaining)
            {
                btn.Text = mainGame.player2.character;
                mainGame.remainingButtons.Remove(btn);
                int winner = mainGame.CheckForWinner();
                btn.Text = "";
                mainGame.remainingButtons.Add(btn);
                if (winner == 2)
                {
                    return btn;
                }
            }
            return null;
        }

        private static Button CheckForPlayer1Win()
        {
            List<Button> remaining = new List<Button>(mainGame.remainingButtons);
            foreach (Button btn in remaining)
            {
                btn.Text = mainGame.player1.character;
                mainGame.remainingButtons.Remove(btn);
                mainGame.isPlayerOneTurn = true;
                int winner = mainGame.CheckForWinner();
                mainGame.ClearButtons(false);
                mainGame.isPlayerOneTurn = false;
                btn.Text = "";
                mainGame.remainingButtons.Add(btn);
                if (winner == 1)
                {
                    return btn;
                }
            }
            return null;
        }

        private static Button ChoseRandomCorner()
        {
            List<Button> corners = new List<Button>(4);
            foreach(Button btn in mainGame.remainingButtons)
            {
                if (btn == mainGame.A1 || btn == mainGame.A3 || btn == mainGame.C1 || btn == mainGame.C3)
                {
                    corners.Add(btn);
                }
            }
            if (corners.Count > 0)
            {
                Random rand = new Random();
                return corners[rand.Next(0, corners.Count())];
            }
            return null;
        }

        private static Button ChoseRandomEdge()
        {
            List<Button> edges = new List<Button>(4);
            foreach (Button btn in mainGame.remainingButtons)
            {
                if (btn == mainGame.A2 || btn == mainGame.B1 || btn == mainGame.B3 || btn == mainGame.C2)
                {
                    edges.Add(btn);
                }
            }
            if (edges.Count > 0)
            {
                Random rand = new Random();
                return edges[rand.Next(0, edges.Count())];
            }
            return null;
        }

        public static Button PerformAiMove(int difficulty = 0)
        {
            if (difficulty == 0)
            {
                Button btn = NoobDifficulty();
                return btn;
            }
            else if (difficulty == 1)
            {
                Button btn = EasyDifficulty();
                return btn;
            }
            return null;
        }

        private static Button NoobDifficulty()
        {
            Button chose;
            chose = CheckForPlayer2Win();
            if (chose != null)
            {
                return chose;
            }
            chose = ChoseRandom();
            return chose;
        }

        private static Button EasyDifficulty()
        {
            Button chose;
            chose = CheckForPlayer2Win();
            if (chose != null)
            {
                return chose;
            }
            chose = CheckForPlayer1Win();
            if (chose != null)
            {
                return chose;
            }
            chose = ChoseRandom();
            return chose;
        }
    }
}
