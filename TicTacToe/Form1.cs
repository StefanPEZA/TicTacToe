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
        public const int NoWinner = 0, Player1Win = 1, Player2Win = 2, Draw = 3;

        public Player player1;
        public Player player2;
        public int scorePlayer1 = 0;
        public int scorePlayer2 = 0;
        public int scoreDraw = 0;

        public List<Button> buttons;
        public List<Button>[] winnerChecking;
        public List<Button> remainingButtons;

        private bool gamePaused = false;
        private bool gameOver = false;
        private bool gameStarted = false;
        public bool isPlayerOneTurn = true;
        private bool isPlayerOneFirst = true;
        private bool playerTwoIsAI = false;
       
        public Form1()
        {
            InitializeComponent();
            InitializeButtonsLists();
            ClearButtons();
            EnableDisableButtons(false);
            player1 = new Player("Player1", "X", this);
            player2 = new Player("Player2", "O", this);
            DifficultyChosen.SelectedIndex = 0;
            UpdateScoreTable();
            UpdateTimer.Enabled = true;
        }

        public void UpdateScoreTable()
        {
            Player1ScoreText.Text = "(" + player1.character + ")" + player1.name + " >";
            Player1Score.Text = scorePlayer1.ToString();

            Player2ScoreText.Text = "(" + player2.character + ")" + player2.name + " >";
            Player2Score.Text = scorePlayer2.ToString();

            DrawScoreText.Text = "Draws" + " >";
            DrawScore.Text = scoreDraw.ToString();
        }

        public void ClearButtons(bool clearText = true)
        {
            if (clearText)
            {
                remainingButtons.Clear();
            }
            foreach (Button btn in buttons)
            {
                if (clearText)
                {
                    btn.Text = "";
                    remainingButtons.Add(btn);
                }
                btn.BackColor = Color.White;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224,224,224);
            }
        }

        private void EnableDisableButtons(bool enabled)
        {
            foreach (Button btn in buttons)
            {
                if (!enabled)
                {
                    if (btn.BackColor == Color.Green)
                    {
                        btn.FlatAppearance.MouseDownBackColor = Color.Green;
                        btn.FlatAppearance.MouseOverBackColor = Color.Green;
                    }
                    else
                    {
                        btn.FlatAppearance.MouseDownBackColor = Color.White;
                        btn.FlatAppearance.MouseOverBackColor = Color.White;
                    }
                    btn.Cursor = Cursors.Arrow;
                }
                else
                {
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224,224,224);
                    btn.FlatAppearance.MouseDownBackColor = Color.Gray;
                    btn.Cursor = Cursors.Hand;
                }
            }
        }

        private void InitializeButtonsLists()
        {
            //All buttons:
            buttons = new List<Button>(9) {
                A1, A2, A3, B1, B2, B3, C1, C2, C3
            };

            remainingButtons = new List<Button>(9) {
                A1, A2, A3, B1, B2, B3, C1, C2, C3
            };

            winnerChecking = new List<Button>[8]; //All posible winning combinations:
            //Lines checking
            winnerChecking[0] = new List<Button>(3){
                A1, A2, A3
            };
            winnerChecking[1] = new List<Button>(3){
                B1, B2, B3
            };
            winnerChecking[2] = new List<Button>(3){
                C1, C2, C3
            };

            //Columns checking
            winnerChecking[3] = new List<Button>(3){
                A1, B1, C1
            };
            winnerChecking[4] = new List<Button>(3){
                A2, B2, C2
            };
            winnerChecking[5] = new List<Button>(3){
                A3, B3, C3
            };

            //Diagonals checking
            winnerChecking[6] = new List<Button>(3){
                A1, B2, C3
            };
            winnerChecking[7] = new List<Button>(3){
                A3, B2, C1
            };
        }

        public void ButtonsClickedByPlayer(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!gamePaused && gameStarted && !gameOver && btn.Text == "")
            {
                if (isPlayerOneTurn)
                {
                    btn.Text = player1.character;
                }
                else
                {
                    btn.Text = player2.character;
                }
                _ = remainingButtons.Remove(btn);

                int winner = CheckForWinner();
                if (winner != NoWinner)
                {
                    EnableDisableButtons(false);
                    gameOver = true;
                    isPlayerOneFirst = !isPlayerOneFirst;
                    if (winner == 1)
                    {
                        ScoreStateText.Text = player1.name + " win!";
                        scorePlayer1++;
                    }
                    else if (winner == 2)
                    {
                        ScoreStateText.Text = player2.name + " win!";
                        scorePlayer2++;
                    }
                    if (winner == 3)
                    {
                        ScoreStateText.Text = "It's a draw!";
                        scoreDraw++;
                    }
                    gameOver = true;
                    UpdateScoreTable();
                    return;
                }

                if (isPlayerOneTurn)
                {
                    isPlayerOneTurn = false;
                }
                else
                {
                    isPlayerOneTurn = true;
                }
                StateText.Text = (isPlayerOneTurn ? player1.name : player2.name) + " turn!";
            }
            else
            {
                return;
            }
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the game? All progress will be deleted!", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ResetButton.Enabled = false;
                resumeButton.Enabled = false;
                playButton.Text = "Play";

                PlayWithAI.Enabled = true;
                if (PlayWithAI.Checked == true)
                {
                    label3.Enabled = true;
                    DifficultyChosen.Enabled = true;
                }

                StateText.Text = "welcome player!";
                ScoreStateText.Text = "no winner yet!";
                ClearButtons();
                EnableDisableButtons(false);
                gameStarted = false;
                isPlayerOneFirst = true;
                isPlayerOneTurn = true;
                gameOver = false;
                gamePaused = false;
                scorePlayer1 = 0;
                scorePlayer2 = 0;
                scoreDraw = 0;
                player1.name = "Player1";
                player1.character = "X";
                player2.name = "Player2";
                player2.character = "O";
                UpdateScoreTable();
            }
        }

        private void PlayButton_Clicked(object sender, EventArgs e)
        {
            if (!gameStarted && !gameOver)
            {
                ResetButton.Enabled = true;
                gameStarted = true;
                playButton.Text = "Replay";
                isPlayerOneTurn = isPlayerOneFirst;
                resumeButton.Enabled = true;
                EnableDisableButtons(true);
                PlayWithAI.Enabled = false;
                label3.Enabled = false;
                DifficultyChosen.Enabled = false;
            }
            else
            {
                DialogResult result = DialogResult.No;
                if (!gameOver)
                    result = MessageBox.Show("Are you sure you want to replay this round?", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes || gameOver)
                {
                    ClearButtons();
                    gameOver = false;
                    isPlayerOneTurn = isPlayerOneFirst;
                    resumeButton.Enabled = true;
                    EnableDisableButtons(true);
                }
                PlayWithAI.Enabled = false;
                label3.Enabled = false;
                DifficultyChosen.Enabled = false;
            }
            StateText.Text = (isPlayerOneTurn ? player1.name : player2.name) + " turn!";
            ScoreStateText.Text = "no winner yet!";
        }

        private void UpdateTick(object sender, EventArgs e)
        {
            if (playerTwoIsAI && !isPlayerOneTurn && !gameOver && !gamePaused && gameStarted)
            {
                AiMove();
            }

        }

        private void PlayWithAI_CheckedChanged(object sender, EventArgs e)
        {
            if (PlayWithAI.Checked == true)
            {
                playerTwoIsAI = true;
                label3.Enabled = true;
                DifficultyChosen.Enabled = true;
                player2.name = "AI_Player";
                UpdateScoreTable();
            }
            else
            {
                playerTwoIsAI = false;
                label3.Enabled = false;
                DifficultyChosen.Enabled = false;
                player2.name = "Player2";
                UpdateScoreTable();
            }
        }

        #region Name changer functionality...
        private void Player1ScoreText_Click(object sender, EventArgs e)
        {
            nameChange2.Enabled = false;
            nameChange2.Visible = false;
            Player2Char.Visible = false;
            nameChange1.Text = player1.name;
            nameChange1.Enabled = true;
            nameChange1.Visible = true;
            Player1Char.Text = "(" + player1.character + ")";
            Player1Char.Visible = true;
            nameChange1.Focus();
            nameChange1.SelectionLength = 0;
            nameChange1.SelectionStart = nameChange1.Text.Length;
        }

        private void NameChange1_KeyDown(object sender, KeyEventArgs e)
        {
            if (nameChange1.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (nameChange1.Text.Length >= 3)
                    {
                        player1.name = nameChange1.Text;
                        nameChange1.Enabled = false;
                        nameChange1.Visible = false;
                        Player1Char.Visible = false;
                        UpdateScoreTable();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        private void Player2ScoreText_Click(object sender, EventArgs e)
        {
            if (playerTwoIsAI)
                return;
            nameChange1.Enabled = false;
            nameChange1.Visible = false;
            Player1Char.Visible = false;
            nameChange2.Text = player2.name;
            nameChange2.Enabled = true;
            nameChange2.Visible = true;
            Player2Char.Text = "(" + player2.character + ")";
            Player2Char.Visible = true;
            nameChange2.Focus();
            nameChange2.SelectionLength = 0;
            nameChange2.SelectionStart = nameChange2.Text.Length;
        }

        private void NameChange2_KeyDown(object sender, KeyEventArgs e)
        {
            if (nameChange2.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (nameChange2.Text.Length >= 3)
                    {
                        player2.name = nameChange2.Text;
                        nameChange2.Enabled = false;
                        nameChange2.Visible = false;
                        Player2Char.Visible = false;
                        UpdateScoreTable();
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        
        private void nameChange1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 'a' && e.KeyChar <= 'z') && !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar == '_') && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void ResumeButton_Clicked(object sender, EventArgs e)
        {
            if (!gamePaused)
            {
                gamePaused = true;
                resumeButton.Text = "Resume";
                EnableDisableButtons(false);
            }
            else
            {
                gamePaused = false;
                resumeButton.Text = "Pause";
                EnableDisableButtons(true);
            }
        }

        public int CheckForWinner()
        {
            Player currentPlayer = isPlayerOneTurn ? player1 : player2;
            for (int i = 0; i < 8; i++)
            {
                if (winnerChecking[i][0].Text == currentPlayer.character)
                {
                    if (winnerChecking[i][0].Text == winnerChecking[i][1].Text && winnerChecking[i][0].Text == winnerChecking[i][2].Text)
                    {
                        winnerChecking[i][0].BackColor = Color.Green;
                        winnerChecking[i][1].BackColor = Color.Green;
                        winnerChecking[i][2].BackColor = Color.Green;
                        return isPlayerOneTurn ? 1 : 2;
                    }
                }
            }

            if (remainingButtons.Count == 0)
            {
                return 3;
            }
            return 0;
        }

        private void AiMove()
        {
            EnableDisableButtons(false);
            int difficulty = 0;
            if (DifficultyChosen.SelectedItem.ToString() == "Noob")
            {
                difficulty = 0;
            }
            else if (DifficultyChosen.SelectedItem.ToString() == "Easy")
            {
                difficulty = 1;
            }
            else if (DifficultyChosen.SelectedItem.ToString() == "Medium")
            {
                difficulty = 1;
            }
            else if (DifficultyChosen.SelectedItem.ToString() == "Hard")
            {
                difficulty = 1;
            }

            Button chosen = Player.PerformAiMove(difficulty);
            System.Threading.Thread.Sleep(200);
            EnableDisableButtons(true);
            chosen.PerformClick();
        }
    }
}
