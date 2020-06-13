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
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScorePlayerX = new System.Windows.Forms.Label();
            this.ScorePlayerO = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.Label();
            this.ScoreBackground = new System.Windows.Forms.PictureBox();
            this.ButtonResetScore = new System.Windows.Forms.Button();
            this.TimerXWinner1 = new System.Windows.Forms.Timer(this.components);
            this.TimerXWinner2 = new System.Windows.Forms.Timer(this.components);
            this.labelWinner = new System.Windows.Forms.Label();
            this.WinnerBackground = new System.Windows.Forms.PictureBox();
            this.ButtonRestartGame = new System.Windows.Forms.Button();
            this.Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnCount = 3;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.Controls.Add(this.pictureBox9, 2, 2);
            this.Grid.Controls.Add(this.pictureBox8, 1, 2);
            this.Grid.Controls.Add(this.pictureBox7, 0, 2);
            this.Grid.Controls.Add(this.pictureBox6, 2, 1);
            this.Grid.Controls.Add(this.pictureBox5, 1, 1);
            this.Grid.Controls.Add(this.pictureBox4, 0, 1);
            this.Grid.Controls.Add(this.pictureBox3, 2, 0);
            this.Grid.Controls.Add(this.pictureBox2, 1, 0);
            this.Grid.Controls.Add(this.pictureBox1, 0, 0);
            this.Grid.Location = new System.Drawing.Point(-9, 83);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 3;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Grid.Size = new System.Drawing.Size(561, 499);
            this.Grid.TabIndex = 0;
            this.Grid.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.Grid_CellPaint);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Location = new System.Drawing.Point(376, 335);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(182, 161);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox9.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(189, 335);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(181, 161);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox8.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(3, 335);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(180, 161);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(376, 169);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(182, 160);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(189, 169);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(181, 160);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(3, 169);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 160);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(376, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 160);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(189, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 160);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Player_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // ScorePlayerX
            // 
            this.ScorePlayerX.AutoSize = true;
            this.ScorePlayerX.BackColor = System.Drawing.Color.Transparent;
            this.ScorePlayerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScorePlayerX.Location = new System.Drawing.Point(276, 9);
            this.ScorePlayerX.Name = "ScorePlayerX";
            this.ScorePlayerX.Size = new System.Drawing.Size(254, 33);
            this.ScorePlayerX.TabIndex = 1;
            this.ScorePlayerX.Text = "Player X score: 0";
            // 
            // ScorePlayerO
            // 
            this.ScorePlayerO.AutoSize = true;
            this.ScorePlayerO.BackColor = System.Drawing.Color.Transparent;
            this.ScorePlayerO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ScorePlayerO.Location = new System.Drawing.Point(-5, 9);
            this.ScorePlayerO.Name = "ScorePlayerO";
            this.ScorePlayerO.Size = new System.Drawing.Size(258, 33);
            this.ScorePlayerO.TabIndex = 2;
            this.ScorePlayerO.Text = "Player O score: 0";
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.AutoSize = true;
            this.PlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PlayerTurn.Location = new System.Drawing.Point(204, 50);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(137, 29);
            this.PlayerTurn.TabIndex = 3;
            this.PlayerTurn.Text = "Player Turn";
            // 
            // ScoreBackground
            // 
            this.ScoreBackground.Location = new System.Drawing.Point(-9, -1);
            this.ScoreBackground.Name = "ScoreBackground";
            this.ScoreBackground.Size = new System.Drawing.Size(561, 84);
            this.ScoreBackground.TabIndex = 4;
            this.ScoreBackground.TabStop = false;
            // 
            // ButtonResetScore
            // 
            this.ButtonResetScore.Location = new System.Drawing.Point(464, 57);
            this.ButtonResetScore.Name = "ButtonResetScore";
            this.ButtonResetScore.Size = new System.Drawing.Size(75, 23);
            this.ButtonResetScore.TabIndex = 5;
            this.ButtonResetScore.Text = "Reset score";
            this.ButtonResetScore.UseVisualStyleBackColor = true;
            this.ButtonResetScore.Click += new System.EventHandler(this.ButtonResetScore_Click);
            // 
            // TimerXWinner1
            // 
            this.TimerXWinner1.Interval = 500;
            this.TimerXWinner1.Tick += new System.EventHandler(this.TimerXWinner1_Tick);
            // 
            // TimerXWinner2
            // 
            this.TimerXWinner2.Interval = 500;
            this.TimerXWinner2.Tick += new System.EventHandler(this.TimerXWinner2_Tick);
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.BackColor = System.Drawing.Color.Transparent;
            this.labelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelWinner.Location = new System.Drawing.Point(214, 585);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(118, 37);
            this.labelWinner.TabIndex = 6;
            this.labelWinner.Text = "label10";
            // 
            // WinnerBackground
            // 
            this.WinnerBackground.Location = new System.Drawing.Point(1, 576);
            this.WinnerBackground.Name = "WinnerBackground";
            this.WinnerBackground.Size = new System.Drawing.Size(551, 54);
            this.WinnerBackground.TabIndex = 7;
            this.WinnerBackground.TabStop = false;
            // 
            // ButtonRestartGame
            // 
            this.ButtonRestartGame.Location = new System.Drawing.Point(464, 588);
            this.ButtonRestartGame.Name = "ButtonRestartGame";
            this.ButtonRestartGame.Size = new System.Drawing.Size(75, 34);
            this.ButtonRestartGame.TabIndex = 8;
            this.ButtonRestartGame.Text = "Restart";
            this.ButtonRestartGame.UseVisualStyleBackColor = true;
            this.ButtonRestartGame.Click += new System.EventHandler(this.ButtonRestartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 629);
            this.Controls.Add(this.ButtonRestartGame);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.WinnerBackground);
            this.Controls.Add(this.ButtonResetScore);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.ScorePlayerO);
            this.Controls.Add(this.ScorePlayerX);
            this.Controls.Add(this.ScoreBackground);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.Label ScorePlayerX;
        private System.Windows.Forms.Label ScorePlayerO;
        private System.Windows.Forms.Label PlayerTurn;
        private System.Windows.Forms.PictureBox ScoreBackground;
        private System.Windows.Forms.Button ButtonResetScore;
        private System.Windows.Forms.Timer TimerXWinner1;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.PictureBox WinnerBackground;
        private System.Windows.Forms.Button ButtonRestartGame;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimerXWinner2;
    }
}

