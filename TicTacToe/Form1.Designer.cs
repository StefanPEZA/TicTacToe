namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DifficultyChosen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayWithAI = new System.Windows.Forms.CheckBox();
            this.ScoreStateText = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.Player2ScoreText = new System.Windows.Forms.Label();
            this.DrawScoreText = new System.Windows.Forms.Label();
            this.Player1ScoreText = new System.Windows.Forms.Label();
            this.DrawScore = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.StateText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resumeButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.ScorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainPanel.Controls.Add(this.DifficultyChosen);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.PlayWithAI);
            this.MainPanel.Controls.Add(this.ScoreStateText);
            this.MainPanel.Controls.Add(this.ResetButton);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.ScorePanel);
            this.MainPanel.Controls.Add(this.StateText);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.resumeButton);
            this.MainPanel.Controls.Add(this.playButton);
            this.MainPanel.Controls.Add(this.C3);
            this.MainPanel.Controls.Add(this.C2);
            this.MainPanel.Controls.Add(this.C1);
            this.MainPanel.Controls.Add(this.B3);
            this.MainPanel.Controls.Add(this.B2);
            this.MainPanel.Controls.Add(this.B1);
            this.MainPanel.Controls.Add(this.A3);
            this.MainPanel.Controls.Add(this.A2);
            this.MainPanel.Controls.Add(this.A1);
            this.MainPanel.Location = new System.Drawing.Point(13, 13);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(691, 425);
            this.MainPanel.TabIndex = 0;
            // 
            // DifficultyChosen
            // 
            this.DifficultyChosen.BackColor = System.Drawing.Color.White;
            this.DifficultyChosen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyChosen.Enabled = false;
            this.DifficultyChosen.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DifficultyChosen.FormattingEnabled = true;
            this.DifficultyChosen.Items.AddRange(new object[] {
            "Noob",
            "Easy",
            "Medium",
            "Hard"});
            this.DifficultyChosen.Location = new System.Drawing.Point(416, 232);
            this.DifficultyChosen.Name = "DifficultyChosen";
            this.DifficultyChosen.Size = new System.Drawing.Size(272, 32);
            this.DifficultyChosen.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(294, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Difficulty:";
            // 
            // PlayWithAI
            // 
            this.PlayWithAI.AutoSize = true;
            this.PlayWithAI.Font = new System.Drawing.Font("Arial Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.PlayWithAI.ForeColor = System.Drawing.Color.White;
            this.PlayWithAI.Location = new System.Drawing.Point(299, 195);
            this.PlayWithAI.Name = "PlayWithAI";
            this.PlayWithAI.Size = new System.Drawing.Size(182, 34);
            this.PlayWithAI.TabIndex = 17;
            this.PlayWithAI.Text = "Play with AI?";
            this.PlayWithAI.UseVisualStyleBackColor = true;
            this.PlayWithAI.CheckedChanged += new System.EventHandler(this.PlayWithAI_CheckedChanged);
            // 
            // ScoreStateText
            // 
            this.ScoreStateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ScoreStateText.Font = new System.Drawing.Font("Arial Black", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ScoreStateText.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreStateText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ScoreStateText.Location = new System.Drawing.Point(382, 278);
            this.ScoreStateText.Margin = new System.Windows.Forms.Padding(0);
            this.ScoreStateText.Name = "ScoreStateText";
            this.ScoreStateText.Size = new System.Drawing.Size(309, 33);
            this.ScoreStateText.TabIndex = 16;
            this.ScoreStateText.Text = "no winner yet!";
            this.ScoreStateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Enabled = false;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResetButton.Location = new System.Drawing.Point(299, 39);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(392, 55);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset the game";
            this.ResetButton.UseCompatibleTextRendering = true;
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Clicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Font = new System.Drawing.Font("Arial Black", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(299, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ScorePanel.Controls.Add(this.Player2ScoreText);
            this.ScorePanel.Controls.Add(this.DrawScoreText);
            this.ScorePanel.Controls.Add(this.Player1ScoreText);
            this.ScorePanel.Controls.Add(this.DrawScore);
            this.ScorePanel.Controls.Add(this.Player2Score);
            this.ScorePanel.Controls.Add(this.Player1Score);
            this.ScorePanel.Location = new System.Drawing.Point(299, 307);
            this.ScorePanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(392, 118);
            this.ScorePanel.TabIndex = 13;
            // 
            // Player2ScoreText
            // 
            this.Player2ScoreText.AutoSize = true;
            this.Player2ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Player2ScoreText.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Player2ScoreText.ForeColor = System.Drawing.Color.White;
            this.Player2ScoreText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player2ScoreText.Location = new System.Drawing.Point(1, 52);
            this.Player2ScoreText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Player2ScoreText.Name = "Player2ScoreText";
            this.Player2ScoreText.Size = new System.Drawing.Size(104, 26);
            this.Player2ScoreText.TabIndex = 20;
            this.Player2ScoreText.Text = "Player2 >";
            // 
            // DrawScoreText
            // 
            this.DrawScoreText.AutoSize = true;
            this.DrawScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DrawScoreText.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DrawScoreText.ForeColor = System.Drawing.Color.White;
            this.DrawScoreText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DrawScoreText.Location = new System.Drawing.Point(1, 84);
            this.DrawScoreText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.DrawScoreText.Name = "DrawScoreText";
            this.DrawScoreText.Size = new System.Drawing.Size(92, 26);
            this.DrawScoreText.TabIndex = 19;
            this.DrawScoreText.Text = "Draws >";
            // 
            // Player1ScoreText
            // 
            this.Player1ScoreText.AutoSize = true;
            this.Player1ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Player1ScoreText.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Player1ScoreText.ForeColor = System.Drawing.Color.White;
            this.Player1ScoreText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player1ScoreText.Location = new System.Drawing.Point(1, 20);
            this.Player1ScoreText.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Player1ScoreText.Name = "Player1ScoreText";
            this.Player1ScoreText.Size = new System.Drawing.Size(104, 26);
            this.Player1ScoreText.TabIndex = 18;
            this.Player1ScoreText.Text = "Player1 >";
            // 
            // DrawScore
            // 
            this.DrawScore.AutoSize = true;
            this.DrawScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DrawScore.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DrawScore.ForeColor = System.Drawing.Color.White;
            this.DrawScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DrawScore.Location = new System.Drawing.Point(344, 84);
            this.DrawScore.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.DrawScore.Name = "DrawScore";
            this.DrawScore.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.DrawScore.Size = new System.Drawing.Size(48, 32);
            this.DrawScore.TabIndex = 17;
            this.DrawScore.Text = "999";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Player2Score.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Player2Score.ForeColor = System.Drawing.Color.White;
            this.Player2Score.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player2Score.Location = new System.Drawing.Point(344, 52);
            this.Player2Score.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Player2Score.Size = new System.Drawing.Size(48, 32);
            this.Player2Score.TabIndex = 16;
            this.Player2Score.Text = "999";
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Player1Score.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Player1Score.ForeColor = System.Drawing.Color.White;
            this.Player1Score.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player1Score.Location = new System.Drawing.Point(344, 20);
            this.Player1Score.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Player1Score.Size = new System.Drawing.Size(48, 32);
            this.Player1Score.TabIndex = 15;
            this.Player1Score.Text = "999";
            // 
            // StateText
            // 
            this.StateText.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StateText.ForeColor = System.Drawing.Color.White;
            this.StateText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StateText.Location = new System.Drawing.Point(379, -2);
            this.StateText.Margin = new System.Windows.Forms.Padding(0);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(311, 36);
            this.StateText.TabIndex = 12;
            this.StateText.Text = "welcome player!";
            this.StateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "State:";
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resumeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resumeButton.Enabled = false;
            this.resumeButton.FlatAppearance.BorderSize = 0;
            this.resumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resumeButton.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.resumeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resumeButton.Location = new System.Drawing.Point(4, 369);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(282, 56);
            this.resumeButton.TabIndex = 10;
            this.resumeButton.Text = "Pause";
            this.resumeButton.UseCompatibleTextRendering = true;
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.ResumeButton_Clicked);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.playButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.playButton.Location = new System.Drawing.Point(4, 307);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(282, 56);
            this.playButton.TabIndex = 9;
            this.playButton.Text = "Play";
            this.playButton.UseCompatibleTextRendering = true;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Clicked);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.White;
            this.C3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C3.FlatAppearance.BorderSize = 0;
            this.C3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.C3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.C3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.C3.Location = new System.Drawing.Point(196, 196);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(90, 90);
            this.C3.TabIndex = 8;
            this.C3.Text = "X";
            this.C3.UseCompatibleTextRendering = true;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.White;
            this.C2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C2.FlatAppearance.BorderSize = 0;
            this.C2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.C2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.C2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.C2.Location = new System.Drawing.Point(100, 196);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(90, 90);
            this.C2.TabIndex = 7;
            this.C2.Text = "O";
            this.C2.UseCompatibleTextRendering = true;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.White;
            this.C1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C1.FlatAppearance.BorderSize = 0;
            this.C1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.C1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.C1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.C1.Location = new System.Drawing.Point(4, 196);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(90, 90);
            this.C1.TabIndex = 6;
            this.C1.Text = "X";
            this.C1.UseCompatibleTextRendering = true;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.White;
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.FlatAppearance.BorderSize = 0;
            this.B3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.B3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.B3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.B3.Location = new System.Drawing.Point(196, 100);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(90, 90);
            this.B3.TabIndex = 5;
            this.B3.Text = "X";
            this.B3.UseCompatibleTextRendering = true;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.White;
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.FlatAppearance.BorderSize = 0;
            this.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.B2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.B2.Location = new System.Drawing.Point(100, 100);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(90, 90);
            this.B2.TabIndex = 4;
            this.B2.Text = "X";
            this.B2.UseCompatibleTextRendering = true;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.White;
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.FlatAppearance.BorderSize = 0;
            this.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.B1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.B1.Location = new System.Drawing.Point(4, 100);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(90, 90);
            this.B1.TabIndex = 3;
            this.B1.Text = "X";
            this.B1.UseCompatibleTextRendering = true;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.White;
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.FlatAppearance.BorderSize = 0;
            this.A3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.A3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.A3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.A3.Location = new System.Drawing.Point(196, 4);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(90, 90);
            this.A3.TabIndex = 2;
            this.A3.Text = "X";
            this.A3.UseCompatibleTextRendering = true;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.White;
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.FlatAppearance.BorderSize = 0;
            this.A2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.A2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.A2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.A2.Location = new System.Drawing.Point(100, 4);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(90, 90);
            this.A2.TabIndex = 1;
            this.A2.Text = "O";
            this.A2.UseCompatibleTextRendering = true;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.White;
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.FlatAppearance.BorderSize = 0;
            this.A1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.A1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.A1.Location = new System.Drawing.Point(4, 3);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(90, 90);
            this.A1.TabIndex = 0;
            this.A1.Text = "X";
            this.A1.UseCompatibleTextRendering = true;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.ButtonsClickedByPlayer);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 50;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Button A1;
        public System.Windows.Forms.Button C3;
        public System.Windows.Forms.Button C2;
        public System.Windows.Forms.Button C1;
        public System.Windows.Forms.Button B3;
        public System.Windows.Forms.Button B2;
        public System.Windows.Forms.Button B1;
        public System.Windows.Forms.Button A3;
        public System.Windows.Forms.Button A2;
        public System.Windows.Forms.Button playButton;
        public System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Label StateText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label DrawScore;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label Player2ScoreText;
        private System.Windows.Forms.Label DrawScoreText;
        private System.Windows.Forms.Label Player1ScoreText;
        public System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ScoreStateText;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.CheckBox PlayWithAI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DifficultyChosen;
    }
}

