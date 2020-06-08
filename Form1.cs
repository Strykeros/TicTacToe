using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        
        bool xPlayerTurn = true;
        int turnCount = 0;
        int scoreO = 0;
        int scoreX = 0;
        string winner;
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
            InitializeGrid();
            InitializeCells();
        }

        private void InitializeGrid()
        {

            Grid.BackColor = Color.LightGreen;
            ScoreBackground.BackColor = Color.Yellow;
            WinnerBackground.BackColor = Color.Yellow;
            labelWinner.BackColor = Color.Yellow;
            ScorePlayerO.BackColor = Color.Yellow;
            ScorePlayerX.BackColor = Color.Yellow;
            PlayerTurn.BackColor = Color.Yellow;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            PlayerTurn.Text = "Player X turn";
        }

        private void InitializeCells()
        {
            label1.Click += Player_Click;
            label2.Click += Player_Click;
            label3.Click += Player_Click;
            label4.Click += Player_Click;
            label5.Click += Player_Click;
            label6.Click += Player_Click;
            label7.Click += Player_Click;
            label8.Click += Player_Click;
            label9.Click += Player_Click;
            string labelName;
            for (int i = 1; i <= 9; i++)
            {
                labelName = "label" + i;
                Grid.Controls[labelName].Text = string.Empty;
                Grid.Controls[labelName].ForeColor = Color.Black;
                Grid.Controls[labelName].BackColor = Color.Transparent;
            }

        }

        public bool thereIsWinner { get; set; }
        
        private void Player_Click(object sender, EventArgs e)
        {
            

            Label label = (Label)sender;
            
            if (label.Text != String.Empty)
            {
                return;
            }
            if (xPlayerTurn)
            {
                label.Text = "X";
                PlayerTurn.Text = "Player O turn";
            }
            else
            {
                label.Text = "O";
                PlayerTurn.Text = "Player X turn";
            }
            
            turnCount++;
            PlaySound("click_sound");
            CheckForWin();
            if(thereIsWinner)
            {
                CheckForWin();
            }
            if (!thereIsWinner)
            {
                CheckForDraw();
            }
            xPlayerTurn = !xPlayerTurn;
        }

        private void WinnerCellsChangeColor()
        {
            if (label1.Text == label2.Text && label1.Text == label3.Text && label1.Text != "")
            {
                ChangeCellColors(label1, label2, label3, Color.Red);
            }
            else if (label4.Text == label5.Text && label4.Text == label6.Text && label4.Text != "")
            {
                ChangeCellColors(label4, label5, label6, Color.Red);
            }
            else if (label7.Text == label8.Text && label7.Text == label9.Text && label7.Text != "")
            {
                ChangeCellColors(label7, label8, label9, Color.Red);
            }
            else if (label1.Text == label4.Text && label1.Text == label7.Text && label1.Text != "")
            {
                ChangeCellColors(label1, label4, label7, Color.Red);
            }
            else if (label2.Text == label5.Text && label2.Text == label8.Text && label2.Text != "")
            {
                ChangeCellColors(label2, label5, label8, Color.Red);
            }
            else if (label3.Text == label6.Text && label3.Text == label9.Text && label3.Text != "")
            {
                ChangeCellColors(label3, label6, label9, Color.Red);
            }
            else if (label1.Text == label5.Text && label1.Text == label9.Text && label1.Text != "")
            {
                ChangeCellColors(label1, label5, label9, Color.Red);
            }
            else if (label3.Text == label5.Text && label3.Text == label7.Text && label3.Text != "")
            {
               ChangeCellColors(label3, label5, label7, Color.Red);
            }

        }


        private void ChangeCellColors(Label firstLabel, Label secondLabel, Label thirdLabel, Color color)
        {
            firstLabel.ForeColor = color;
            secondLabel.ForeColor = color;
            thirdLabel.ForeColor = color;
        }


        private void PlaySound(string soundName)
        {
            System.IO.Stream str = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(soundName);
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void PlayWinnerSound(string winnerSoundName)
        {
            System.IO.Stream str = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(winnerSoundName);
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void CheckForDraw()
        {

            if (label1.Text != string.Empty &&
               label2.Text != string.Empty &&
               label3.Text != string.Empty &&
               label4.Text != string.Empty &&
                label5.Text != string.Empty &&
                label6.Text != string.Empty &&
                label7.Text != string.Empty &&
                label8.Text != string.Empty &&
                label9.Text != string.Empty)
            {
                labelWinner.Text = "Draw!";
                this.Size = new Size(567, 668);
            }
          
        }

        private void CheckForWin()
        {
            if (
                    (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != string.Empty) ||
                    (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != string.Empty) ||
                    (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != string.Empty) ||
                    (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != string.Empty) ||
                    (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != string.Empty) ||
                    (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != string.Empty) ||
                    (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != string.Empty) ||
                    (label3.Text == label5.Text && label5.Text == label7.Text && label3.Text != string.Empty)
                )
            {
               
                GameOver();
                label1.Click -= Player_Click;
                label2.Click -= Player_Click;
                label3.Click -= Player_Click;
                label4.Click -= Player_Click;
                label5.Click -= Player_Click;
                label6.Click -= Player_Click;
                label7.Click -= Player_Click;
                label8.Click -= Player_Click;
                label9.Click -= Player_Click;
            }
        }

        public bool WinnerO { get; set; }
        public bool WinnerX { get; set; }
        public bool gameOver { get; set; }
        private void GameOver()
        {
            gameOver = true;
            string winner;
            
            if (xPlayerTurn)
            {
                if(thereIsWinner)
                {
                    return;
                }
                
                WinnerX = true;
                WinnerO = false;
                winner = "X";
            }
            else
            {

                if(thereIsWinner)
                {
                    return;
                }   
                WinnerO = true;
                WinnerX = false;
                winner = "O";
            }
            if(WinnerO && !WinnerX)
            {
                
                UpdateScoreOLabel();
            }
            if (WinnerX && !WinnerO)
            {
                
                UpdateScoreXLabel();
            }
            WinnerCellsChangeColor();
            this.Size = new Size(567, 668);
            PlayWinnerSound("cheer3");
            labelWinner.Text = winner + " wins!";
            
        }

        private void ButtonRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
            
        }

        private void UpdateScoreOLabel()
        {
            scoreO += 1;
            ScorePlayerO.Text = "Player O score: " + scoreO;
            thereIsWinner = true;
        }

        private void UpdateScoreXLabel()
        {
            scoreX += 1;
            ScorePlayerX.Text = "Player X score: " + scoreX;
            thereIsWinner = true;
        }

        private void RestartGame()
        {
            thereIsWinner = false;
            InitializeCells();
            this.Size = new Size(567, 615);
            TimerWinner1.Stop();
            TimerWinner2.Stop();
            turnCount = 0;
        }


        private void ButtonResetScore_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                ScorePlayerX.Text = "Player X score: 0";
                ScorePlayerO.Text = "Player O score: 0";
                scoreX = 0;
                scoreO = 0;
            }
            else if(result == DialogResult.No)
            {
                return;
            }
        }

        private void Grid_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column > -10 && e.Row > -2)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            }

        }

        private void label_Paint(object sender, PaintEventArgs e)
        {
            
            if (label1.Text == label2.Text && label1.Text == label3.Text && label1.Text != "")
            {
                TimerWinner1.Start();
            }
            else if (label4.Text == label5.Text && label4.Text == label6.Text && label4.Text != "")
            {
                TimerWinner1.Start();
            }
            else if (label7.Text == label8.Text && label7.Text == label9.Text && label7.Text != "")
            {
                TimerWinner1.Start();
            }
            else if (label1.Text == label4.Text && label1.Text == label7.Text && label1.Text != "")
            {
                TimerWinner1.Start();
            }
            else if (label2.Text == label5.Text && label2.Text == label8.Text && label2.Text != "")
            {
                TimerWinner1.Start();
            }
            else if (label3.Text == label6.Text && label3.Text == label9.Text && label3.Text != "")
            {
                TimerWinner1.Start();
            }
            else if (label1.Text == label5.Text && label1.Text == label9.Text && label1.Text != "")
            {
                TimerWinner1.Start();
            }
            else if (label3.Text == label5.Text && label3.Text == label7.Text && label3.Text != "")
            {
                TimerWinner1.Start();
            }
        }

        private void TimerWinner1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text && label1.Text == label3.Text && label1.Text != "")
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
            }
            else if (label4.Text == label5.Text && label4.Text == label6.Text && label4.Text != "")
            {
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
            }
            else if (label7.Text == label8.Text && label7.Text == label9.Text && label7.Text != "")
            {
                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
            }
            else if (label1.Text == label4.Text && label1.Text == label7.Text && label1.Text != "")
            {
                label1.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label7.ForeColor = Color.Red;
            }
            else if (label2.Text == label5.Text && label2.Text == label8.Text && label2.Text != "")
            {
                label2.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
            }
            else if (label3.Text == label6.Text && label3.Text == label9.Text && label3.Text != "")
            {
                label3.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
            }
            else if (label1.Text == label5.Text && label1.Text == label9.Text && label1.Text != "")
            {
                label1.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
            }
            else if (label3.Text == label5.Text && label3.Text == label7.Text && label3.Text != "")
            {
                label7.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
            }
            TimerWinner1.Stop();
            TimerWinner2.Start();
        }

        private void TimerWinner2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text && label1.Text == label3.Text && label1.Text != "")
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }
            else if (label4.Text == label5.Text && label4.Text == label6.Text && label4.Text != "")
            {
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            else if (label7.Text == label8.Text && label7.Text == label9.Text && label7.Text != "")
            {
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
            }
            else if (label1.Text == label4.Text && label1.Text == label7.Text && label1.Text != "")
            {
                label1.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
            }
            else if (label2.Text == label5.Text && label2.Text == label8.Text && label2.Text != "")
            {
                label2.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
            else if (label3.Text == label6.Text && label3.Text == label9.Text && label3.Text != "")
            {
                label3.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
            }
            else if (label1.Text == label5.Text && label1.Text == label9.Text && label1.Text != "")
            {
                label1.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
            }
            else if (label3.Text == label5.Text && label3.Text == label7.Text && label3.Text != "")
            {
                label7.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }
            TimerWinner2.Stop();
            TimerWinner1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(567, 615);
        }


    }
}
