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
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class Settings
    {
        
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction {get; set;}
        public Settings()
        {
            Width = 15;
            Height = 15;
            Speed = 5;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
           
        }
    }
}
