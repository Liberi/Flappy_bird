using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {
        List<PictureBox> Pipe = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            Pipe = new List<PictureBox>() { pipe1, pipe2, pipe3, pipe4 };
        }
        int Speed = 3;
        int gravity = 5;
        int score = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            foreach (var pip in Pipe)
            {
                if (bird.Bounds.IntersectsWith(pip.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds) || bird.Top == ground.Location.X)
                {
                    endGame();
                }
                pip.Left -= Speed;
                if (pip.Left < -pip.Width)
                {
                    pip.Left = this.Width + pip.Width;
                    score++;
                }
            }
            ScoreText.Text = "Score: " + (score / 2).ToString();
            if (score > 20)
            {
                Speed = Speed * 2;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
            if (e.KeyCode == Keys.Enter)
            {
                startGame();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            Fail.Visible = true;
        }
        private void startGame()
        {
            gameTimer.Start();
            Fail.Visible = false;
            score = 0;
            bird.Location = new Point(60, 235);
            for (int i = 0; i < Pipe.Count; i++)
            {
                if (i < 2)
                {
                    Pipe[i].Left = this.Width + pipe1.Width;
                }
                else 
                {
                    Pipe[i].Left = this.Width/2 + pipe1.Width;
                }
            }
        }
    }
}
