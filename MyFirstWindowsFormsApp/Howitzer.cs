using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstWindowsFormsApp
{
    public class Howitzer
    {
        private const int Width = 100;
        private const int Height = 30;
        private const float barrel_len = 100;

        private const int Radius = 10;

        public float X, Y;
        public float Dir;
        public float mv = 300;

        public Howitzer() 
        { 
            X = 0;
            Y = 0;
            Dir = 0;
        }
        public bool Collide(int x, int y)
        {
            if (x < this.X + (Width / 2) && x > this.X - (Width / 2)
                && y < this.Y + (Height / 2) && y > this.Y - (Height / 2)) 
            { 
                return true; 
            }
            return false;
        }

        public Howitzer(float x, float y, float dir)
        {
            X = x;
            Y = y;
            Dir = dir;
        }
        public Ball Fire()
        {
            float end_X = (float)(barrel_len * Math.Sin(Dir));
            float end_Y = (float)(barrel_len * Math.Cos(Dir));
            float len = MathF.Sqrt(end_X* end_X + end_Y* end_Y);
            return new Ball(end_X + X, end_Y + Y, 50, end_X / len * mv, end_Y /len * mv);
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Azure, X - Width/2, Y - Height/2, Width, Height);


            float end_X = (float)(barrel_len * Math.Sin(Dir)) + X;
            float end_Y = (float)(barrel_len * Math.Cos(Dir)) + Y;
            Pen cannon_pen = new Pen(Color.Magenta, 10);
            g.DrawLine(cannon_pen, X, Y, end_X, end_Y);


            g.FillEllipse(Brushes.Black, X - Width / 2, Y - Height / 2 - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(Brushes.Black, X + Width / 2 - 2*Radius, Y - Height / 2 - Radius, 2 * Radius, 2 * Radius);
        }
    }
}
