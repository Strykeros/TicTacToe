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

        private Timer timerAnimation = null;
        private Timer timerOWinner1 = null;
        private Timer timerOWinner2 = null;
        bool xPlayerTurn = true;
        int turnCount = 0;
        int scoreO = 0;
        int scoreX = 0;
        double tickX = 0;
        double tickO = 0;
        string winner;
        int pictureCounter = 1;
        PictureBox picture;
        
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
            InitializeGrid();
            InitializeCells();
            InitializeTimerAnimation();
            InitializeTimerOWinner1();
            InitializeTimerOWinner2();
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
            pictureBox1.Click += Player_Click;
            pictureBox2.Click += Player_Click;
            pictureBox3.Click += Player_Click;
            pictureBox4.Click += Player_Click;
            pictureBox5.Click += Player_Click;
            pictureBox6.Click += Player_Click;
            pictureBox7.Click += Player_Click;
            pictureBox8.Click += Player_Click;
            pictureBox9.Click += Player_Click;
            string labelName;
            for (int i = 1; i <= 9; i++)
            {
                ResetPictureBoxes();
                labelName = "pictureBox" + i;
                Grid.Controls[labelName].Tag = String.Empty;
                Grid.Controls[labelName].ForeColor = Color.LightGreen;
                Grid.Controls[labelName].BackColor = Color.Transparent;
            }
        }

        private void InitializeTimerAnimation()
        {
            timerAnimation = new Timer();
            timerAnimation.Interval = 35;
            timerAnimation.Tick += new EventHandler(TimerAnimation_Tick);
        }

        private void InitializeTimerOWinner1() 
        {
            timerOWinner1 = new Timer();
            timerOWinner1.Interval = 500;
            timerOWinner1.Tick += new EventHandler(TimerOWinner1_Tick);
        }

        private void InitializeTimerOWinner2()
        {
            timerOWinner2 = new Timer();
            timerOWinner2.Interval = 500;
            timerOWinner2.Tick += new EventHandler(TimerOWinner2_Tick);
        }

        public bool thereIsWinner { get; set; }
        
        private void Player_Click(object sender, EventArgs e)
        {
            

            PictureBox pic = (PictureBox)sender;
            
            if (pic.Tag != String.Empty)
            {
                return;
            }
            if (xPlayerTurn)
            {
                pic.Tag = "X";
                picture = pic;
                timerAnimation.Start();
                PlayXSound("X_sound");
                PlayerTurn.Text = "Player O turn";
            }
            else
            {
                pic.Tag = "O";
                picture = pic;
                timerAnimation.Start();
                PlayOSound("O_sound");
                PlayerTurn.Text = "Player X turn";
            }
            
            turnCount++;
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



        private void PlayXSound(string soundName)
        {
            System.IO.Stream str = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(soundName);
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void PlayOSound(string soundName)
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

            if (pictureBox1.Tag != string.Empty &&
               pictureBox2.Tag != string.Empty &&
               pictureBox3.Tag != string.Empty &&
               pictureBox4.Tag != string.Empty &&
                pictureBox5.Tag != string.Empty &&
                pictureBox6.Tag != string.Empty &&
                pictureBox7.Tag != string.Empty &&
                pictureBox8.Tag != string.Empty &&
                pictureBox9.Tag != string.Empty)
            {
                labelWinner.Text = "Draw!";
                this.Size = new Size(567, 668);
            }
          
        }

        private void CheckForWin()
        {
            if (
                    (pictureBox1.Tag == pictureBox2.Tag && pictureBox2.Tag == pictureBox3.Tag && pictureBox1.Tag != string.Empty) ||
                    (pictureBox4.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox6.Tag && pictureBox4.Tag != string.Empty) ||
                    (pictureBox7.Tag == pictureBox8.Tag && pictureBox8.Tag == pictureBox9.Tag && pictureBox7.Tag != string.Empty) ||
                    (pictureBox1.Tag == pictureBox4.Tag && pictureBox4.Tag == pictureBox7.Tag && pictureBox1.Tag != string.Empty) ||
                    (pictureBox2.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox8.Tag && pictureBox2.Tag != string.Empty) ||
                    (pictureBox3.Tag == pictureBox6.Tag && pictureBox6.Tag == pictureBox9.Tag && pictureBox3.Tag != string.Empty) ||
                    (pictureBox1.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox9.Tag && pictureBox1.Tag != string.Empty) ||
                    (pictureBox3.Tag == pictureBox5.Tag && pictureBox5.Tag == pictureBox7.Tag && pictureBox3.Tag != string.Empty)
                )
            {
                GameOver();
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
            gameOver = false;
            InitializeCells();
            this.Size = new Size(567, 615);
            TimerXWinner1.Stop();
            TimerXWinner2.Stop();
            timerOWinner1.Stop();
            timerOWinner2.Stop();
            turnCount = 0;
            tickX = 0;
            tickO = 0;
        }

        private void ResetPictureBoxes()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
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

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pict = (PictureBox)sender;
            if (pict.Tag == "X")
            {
                TimerXWinner1.Start();
            }
            else
            {
                timerOWinner1.Start();
            }
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)  //manually created timer
        {
            pictureBox1.Click -= Player_Click;
            pictureBox2.Click -= Player_Click;
            pictureBox3.Click -= Player_Click;
            pictureBox4.Click -= Player_Click;
            pictureBox5.Click -= Player_Click;
            pictureBox6.Click -= Player_Click;
            pictureBox7.Click -= Player_Click;
            pictureBox8.Click -= Player_Click;
            pictureBox9.Click -= Player_Click;
            Animate();
        }

        private void Animate()
        {
            string turn;
            string pictureName;
            turn = picture.Tag.ToString();
            
            if(!xPlayerTurn)
            {
                pictureName = "X_0" + pictureCounter.ToString("00");
                picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictureName);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureCounter += 1;
                if (pictureCounter > 15)
                {
                    pictureCounter = 1;
                    pictureBox1.Click += Player_Click;
                    pictureBox2.Click += Player_Click;
                    pictureBox3.Click += Player_Click;
                    pictureBox4.Click += Player_Click;
                    pictureBox5.Click += Player_Click;
                    pictureBox6.Click += Player_Click;
                    pictureBox7.Click += Player_Click;
                    pictureBox8.Click += Player_Click;
                    pictureBox9.Click += Player_Click;

                    if (gameOver)
                    {
                        pictureBox1.Click -= Player_Click;
                        pictureBox2.Click -= Player_Click;
                        pictureBox3.Click -= Player_Click;
                        pictureBox4.Click -= Player_Click;
                        pictureBox5.Click -= Player_Click;
                        pictureBox6.Click -= Player_Click;
                        pictureBox7.Click -= Player_Click;
                        pictureBox8.Click -= Player_Click;
                        pictureBox9.Click -= Player_Click;
                    }
                    timerAnimation.Stop();
                }
            }
            else
            {
                pictureName = "O_0" + pictureCounter.ToString("00");
                picture.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictureName);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureCounter += 1;
                if (pictureCounter > 15)
                {
                    pictureCounter = 1;
                    pictureBox1.Click += Player_Click;
                    pictureBox2.Click += Player_Click;
                    pictureBox3.Click += Player_Click;
                    pictureBox4.Click += Player_Click;
                    pictureBox5.Click += Player_Click;
                    pictureBox6.Click += Player_Click;
                    pictureBox7.Click += Player_Click;
                    pictureBox8.Click += Player_Click;
                    pictureBox9.Click += Player_Click;

                    if(gameOver)
                    {
                        pictureBox1.Click -= Player_Click;
                        pictureBox2.Click -= Player_Click;
                        pictureBox3.Click -= Player_Click;
                        pictureBox4.Click -= Player_Click;
                        pictureBox5.Click -= Player_Click;
                        pictureBox6.Click -= Player_Click;
                        pictureBox7.Click -= Player_Click;
                        pictureBox8.Click -= Player_Click;
                        pictureBox9.Click -= Player_Click;
                    }
                    timerAnimation.Stop();
                }
            }
            
        }

        private void TimerXWinner1_Tick(object sender, EventArgs e)
        {
            ++tickX;
            if (tickX > 8)
            {

                if (pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag && pictureBox1.Tag == "X")
                {
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag && pictureBox4.Tag == "X")
                {
                    pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag && pictureBox7.Tag == "X")
                {
                    pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag && pictureBox1.Tag == "X")
                {
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag && pictureBox2.Tag == "X")
                {
                    pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag && pictureBox3.Tag == "X")
                {
                    pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag && pictureBox1.Tag == "X")
                {
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag && pictureBox3.Tag == "X")
                {
                    pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
            TimerXWinner1.Stop();
            TimerXWinner2.Start();
        }

        private void TimerXWinner2_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag && pictureBox1.Tag == "X")
            {
                
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag && pictureBox4.Tag == "X")
            {
                pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag && pictureBox7.Tag == "X")
            {
                pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag && pictureBox1.Tag == "X")
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag && pictureBox2.Tag == "X")
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag && pictureBox3.Tag == "X")
            {
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag && pictureBox1.Tag == "X")
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag && pictureBox3.Tag == "X")
            {
                pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("X_Blue");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            TimerXWinner2.Stop();
            TimerXWinner1.Start();
        }

        private void TimerOWinner1_Tick(object sender, EventArgs e)  // manually created timer
        {
            ++tickO;
            if (tickO > 16.5)
            {

                if (pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag && pictureBox1.Tag == "O")
                {
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag && pictureBox4.Tag == "O")
                {
                    pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag && pictureBox7.Tag == "O")
                {
                    pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag && pictureBox1.Tag == "O")
                {
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag && pictureBox2.Tag == "O")
                {
                    pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag && pictureBox3.Tag == "O")
                {
                    pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag && pictureBox1.Tag == "O")
                {
                    pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag && pictureBox3.Tag == "O")
                {
                    pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Red");
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                timerOWinner1.Stop();
                timerOWinner2.Start();
            }
        }

        private void TimerOWinner2_Tick(object sender, EventArgs e)  // manually created timer
        {
            if (pictureBox1.Tag == pictureBox2.Tag && pictureBox1.Tag == pictureBox3.Tag && pictureBox1.Tag == "O")
            {

                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox4.Tag == pictureBox5.Tag && pictureBox4.Tag == pictureBox6.Tag && pictureBox4.Tag == "O")
            {
                pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox7.Tag == pictureBox8.Tag && pictureBox7.Tag == pictureBox9.Tag && pictureBox7.Tag == "O")
            {
                pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox1.Tag == pictureBox4.Tag && pictureBox1.Tag == pictureBox7.Tag && pictureBox1.Tag == "O")
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox2.Tag == pictureBox5.Tag && pictureBox2.Tag == pictureBox8.Tag && pictureBox2.Tag == "O")
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox3.Tag == pictureBox6.Tag && pictureBox3.Tag == pictureBox9.Tag && pictureBox3.Tag == "O")
            {
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox1.Tag == pictureBox5.Tag && pictureBox1.Tag == pictureBox9.Tag && pictureBox1.Tag == "O")
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox9.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (pictureBox3.Tag == pictureBox5.Tag && pictureBox3.Tag == pictureBox7.Tag && pictureBox3.Tag == "O")
            {
                pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject("O_Orange");
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            timerOWinner2.Stop();
            timerOWinner1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(567, 615);
        }


    }
}
