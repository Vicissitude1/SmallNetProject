using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmallNetGame
{
    public partial class PongForm : Form
    {
        public PongForm()
        {
            InitializeComponent();
        }

        private void PongForm_Load(object sender, EventArgs e)
        {
            btm = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(btm);
            SCG = this.CreateGraphics();

            ball = new Rectangle(this.Width / 2, this.Height / 2, 40, 40);
            RightSide = new Rectangle(this.Width - 50, this.Height / 2, 30, 150);
            LeftSide = new Rectangle(5, this.Height / 2, 30, 150);

            thread = new Thread(draw);
            thread.IsBackground = true;

            thread.Start();
        }
        Bitmap btm;
        Graphics g;
        Graphics SCG;

        Thread thread;

        Rectangle ball = Rectangle.Empty;
        Rectangle LeftSide = Rectangle.Empty;
        Rectangle RightSide = Rectangle.Empty;

        int ball_speed = 7;
        int ball_speedY = 7;
        int move_speed = 7;

        Point moveTo = Point.Empty;
        Point ballMove = Point.Empty;

        bool drawing = true;

        public void draw()
        {
            try
            {
                while (drawing)
                {
                    g.Clear(Color.White);

                    if (moveTo.Y > RightSide.Y + 100) RightSide.Y += move_speed;
                    if (moveTo.Y < RightSide.Y + 100) RightSide.Y -= move_speed;

                    if (moveTo.Y > LeftSide.Y + 100) LeftSide.Y += move_speed;
                    if (moveTo.Y < LeftSide.Y + 100) LeftSide.Y -= move_speed;

                    ball.X += ball_speed;

                    if (ballMove.Y > ball.Y + 100) ball.Y += ball_speedY;
                    if (ballMove.Y < ball.Y + 100) ball.Y -= ball_speedY;

                    if (RightSide.IntersectsWith(ball))
                    {
                        ball_speed *= -1;
                    }

                    if (LeftSide.IntersectsWith(ball))
                    {
                        ball_speed *= -1;
                    }

                    if (ball.Y < 20) ballMove.Y = this.Height;
                    if (ball.Y > this.Height - 80) ballMove.Y = 0;

                    if (ball.X < -40) ball.X = this.Width / 2;
                    if (ball.X > this.Width) ball.X = this.Width / 2;

                    g.FillRectangle(Brushes.Black, LeftSide);
                    g.FillRectangle(Brushes.Black, RightSide);
                    g.FillEllipse(Brushes.Black, ball);

                    SCG.DrawImage(btm, 0, 0, this.Width, this.Height);
                }
            }
            catch { }
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            ballMove = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            moveTo = e.Location;
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
