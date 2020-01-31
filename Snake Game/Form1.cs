using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        private int highestScore = 0;

        //Declaring an array comprised of radio buttons
        public RadioButton[] buttonArray;
        
        public Form1()
        {
            InitializeComponent();
            new Settings();
            Settings.Speed = 5;
            Die();
            highScore.Text = highestScore.ToString();

            //Setting up the button array
            buttonArray = new RadioButton[] { level1, level2, level3, level4, level5 };
            label1.Text = "Press button to start a new game";
            
            //Setting up the speed of the snake game wrt to the checked level
            for (int i = 0; i < buttonArray.Length; i++)
            {
                if (buttonArray[i].Checked == true)
                {
                    Settings.Speed += 3 * i;
                }
            }
            //Setting up tickrate and game timer interval
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void StartGame()
        {
            label1.Visible = false;
            new Settings();
            Settings.Speed = 5;
            label1.Text = "";
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);
            ScoreLabel.Text = Settings.Score.ToString();
            GenerateFood();
            highScore.Text = highestScore.ToString();
            for (int i = 0; i < buttonArray.Length; i++)
            {
                if (buttonArray[i].Checked == true)
                {
                    Settings.Speed += 3*i;
                }
            }
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Start();
        }
        private void GenerateFood()
        {
            int maxXPos = GameBox.Size.Width / Settings.Width;
            int maxYPos = GameBox.Size.Height / Settings.Height;
            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                }
                if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }
                MovePlayer();
            }
            
            GameBox.Invalidate();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void GameBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Settings.GameOver != true)
            {
                Brush snakecolor;
                for (int i=0; i < Snake.Count; i++)
                {
                    if (i == 0)
                        snakecolor = Brushes.Black;
                    else
                        snakecolor = Brushes.Green;

                    canvas.FillEllipse(snakecolor, new Rectangle(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));
                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }
            else
            {
                string gameOver = "" + Settings.Score + "";
            }
        }

        private void Die()
        {
            if (Settings.Score > highestScore)
                highestScore = Settings.Score;
            highScore.Text = highestScore.ToString();
            Settings.GameOver = true;
            label1.Text = "Game Over. Press \n Enter to start a new game";
            label1.Visible = true;
            foreach (Control c in panel1.Controls)
            {
                {
                    c.Enabled = true;
                    c.Visible = true;
                    levels.Visible = true;
                }
            }
                
           
            button1.Enabled = true;
        }
        private  void Eat()
        {
            Circle food = new Circle();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;
            Snake.Add(food);
            Settings.Score += Settings.Points;
            ScoreLabel.Text = Settings.Score.ToString();

            GenerateFood();
        }
        private void MovePlayer()
        {
            for (int i = Snake.Count -1;i>=0; i--)
            {
                if ( i==0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }

                    int maxXPos = GameBox.Size.Width / Settings.Width;
                    int maxYPos = GameBox.Size.Height / Settings.Height;

                    if (Snake[i].X <0 || Snake[i].Y <0 || Snake[i].X> maxXPos || Snake[i].Y > maxYPos)
                    {
                        Die();
                    }

                    for (int j =1; j < Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }
                    if(Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;

                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void highScore_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.Enabled = false;
                c.Visible = false;
                levels.Visible = false;
            }
            new Settings();
            StartGame();
            highScore.Text = highestScore.ToString();
            button1.Enabled = false;
        }
    }
}
