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
            ScorePlayerO.BackColor = Color.Yellow;
            ScorePlayerX.BackColor = Color.Yellow;
            PlayerTurn.BackColor = Color.Yellow;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            PlayerTurn.Text = "Player X turn";
        }

        private void InitializeCells()
        {

            string labelName;
            for (int i = 1; i <= 9; i++)
            {
                labelName = "label" + i;
                Grid.Controls[labelName].Text = string.Empty;
                Grid.Controls[labelName].BackColor = Color.Transparent;
            }

        }


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
            CheckForDraw();
            xPlayerTurn = !xPlayerTurn;
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
            }
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
            firstLabel.BackColor = color;
            secondLabel.BackColor = color;
            thirdLabel.BackColor = color;
        }


        private void PlaySound(string soundName)
        {
            System.IO.Stream str = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(soundName);
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }


        private void CheckForDraw()
        {

            if(turnCount == 9)
            {
                MessageBox.Show("Draw!");
                InitializeCells();
            }
        }

        public bool WinnerO { get; set; }
        public bool WinnerX { get; set; }
        private void GameOver()
        {

            string winner;
            if(xPlayerTurn)
            {
                WinnerX = true;
                WinnerO = false;
                winner = "X";
            }
            else
            {
                WinnerO = true;
                WinnerX = false;
                winner = "O";
            }
            if(WinnerO && !WinnerX)
            {
                scoreO += 1;
                UpdateScoreOLabel();
            }
            
            if (WinnerX && !WinnerO)
            {
                scoreX += 1;
                UpdateScoreXLabel();
            }
            WinnerCellsChangeColor();
            MessageBox.Show(winner + " wins!");
            RestartGame();
        }

        private void UpdateScoreOLabel()
        {
            ScorePlayerO.Text = "Player O score: " + scoreO;
        }

        private void UpdateScoreXLabel()
        {
            ScorePlayerX.Text = "Player X score: " + scoreX;
        }

        private void RestartGame()
        {
            InitializeCells();
            turnCount = 0;
        }


        private void ButtonResetScore_Click(object sender, EventArgs e)
        {
            ScorePlayerX.Text = "Player X score: 0";
            ScorePlayerO.Text = "Player O score: 0";
            scoreX = 0;
            scoreO = 0;
        }

        private void Grid_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column > -10 && e.Row > -2)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            }

        }
    }
}
