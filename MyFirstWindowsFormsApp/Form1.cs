using System.Diagnostics;
using System.Runtime.CompilerServices;
using Timer = System.Windows.Forms.Timer;

namespace MyFirstWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private const int V = 10;

        //public int X;
        //public Howitzer howitzer;
        public List<Howitzer> howitzers = new List<Howitzer>
            {
                new Howitzer(10, 20,  0),
                new Howitzer(20, 20, 0),
                new Howitzer(30, 20, 0),
                new Howitzer(40, 20, 0),
                new Howitzer(50, 20, 0),
                new Howitzer(60, 20, 0),
                new Howitzer(70, 20, 0),
            };
        public List<Enemy> enemies = new List<Enemy>
        {
            new Enemy(110, 200, 50),
            new Enemy(110, 250, 30),
            new Enemy(140, 200, 50),
            new Enemy(130, 220, 40),
            new Enemy(110, 220, 60),
        };
        public List<Ball> balls = new List<Ball>()
        {

        };
        private int N, ind = 0;
        public float tickTime = 0.02f;


        public Form1()
        {
            InitializeComponent();
            //howitzer = new Howitzer(40, 40, (float)Math.PI / 6);
            N = howitzers.Count;
            tickTime = updateTimer.Interval / 1000f;

        }

        private void Guziol_right_Click(object sender, EventArgs e)
        {
            howitzers[ind].X += V;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void myForm_MouseClick(object sender, MouseEventArgs e)
        {
            int myX = e.X;
            int myY = pictureBox1.Height - e.Y;

            for (int i = 0; i < howitzers.Count; i++)
            {
                if (howitzers[i].Collide(myX, myY))
                {
                    this.ind = i;
                    break;
                }
            }

            Debug.Print($"x: {myX}, y: {myY}, new_ind: {ind}");
        }

        private void Picture_box_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(0, pictureBox1.Height);
            g.ScaleTransform(1, -1);
            //g.FillEllipse(Brushes.Red, this.X, 100, 20, 20);
            foreach (Howitzer h in howitzers)
            {
                h.Draw(g);
            }
            foreach (Enemy enemy in enemies)
            {
                enemy.Draw(g);
            }
            foreach (Ball ball in balls)
            {
                ball.Draw(g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            howitzers[ind].X -= V;
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            howitzers[ind].Dir += MathF.PI / 12;
            pictureBox1.Invalidate();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            howitzers[ind].Dir = (float)(MathF.PI / 2 * trackBar1.Value / 1000.0);
            pictureBox1.Invalidate(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        const float dir_step = MathF.PI / 60;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case 'a':
                    howitzers[ind].X -= V;
                    break;
                case 'd':
                    howitzers[ind].X += V;
                    break;
                case 'z':
                    howitzers[ind].Dir -= dir_step;
                    break;
                case 'c':
                    howitzers[ind].Dir += dir_step;
                    break;
                case 'w':
                    balls.Add(howitzers[ind].Fire());
                    break;
                default:
                    Debug.Print($"Unknown key: {e.KeyChar}");
                    break;

            }
            pictureBox1.Invalidate();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            foreach (var enemy in enemies)
            {
                enemy.Update(tickTime);
            }
            List<int> removed_balls = new List<int>();
            List<Enemy> removedEnemies = new List<Enemy>();
            for (int i = 0; i < balls.Count; ++i)
            {
                Ball ball = balls[i];
                ball.Update(tickTime);
                foreach(Enemy enemy in enemies)
                {
                    if (ball.collide(enemy))
                    {
                        removedEnemies.Add(enemy);
                    }
                }

                if (ball.x < -100 || ball.x > pictureBox1.Width + 100)
                {
                    removed_balls.Add(i);
                }
                else if (ball.y <= ball.radius && ball.speed_y < 0)
                {
                    ball.speed_y = -ball.speed_y;
                }
            }
            for( int i = removed_balls.Count -1; i >= 0; i--)
            {
                balls.RemoveAt(i);
            }
            foreach(Enemy enemy in removedEnemies)
            {
                enemies.Remove(enemy);
            }

            pictureBox1.Invalidate();
        }
    }
}