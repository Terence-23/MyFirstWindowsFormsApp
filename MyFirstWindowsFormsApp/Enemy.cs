using System;
using System.Diagnostics;

public class Enemy
{
	public float x = 10, y = 10;
    public int width = 10, height = 10;
    public float speed = 10;
    private Random random = new Random();

    public void Draw(Graphics g)
    {
        g.FillRectangle(Brushes.Black, x -width / 2, y - height / 2, width, height);
    }
    public Enemy()
	{
        
	}

    public Enemy(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Enemy(float x, float y, float speed) : this(x, y)
    {
        this.speed = speed;
    }

    public void Update(float time)
    {
        float x_dif = (float)((double)random.Next() / Int32.MaxValue * 2) - 1.0f;
        float y_dif = (float)((double)random.Next() / Int32.MaxValue * 2) - 1.0f;
        
        float len = MathF.Sqrt(x_dif * x_dif + y_dif * y_dif);

        x += x_dif * speed * time / len;
        y += y_dif * speed * time / len;
        
        
    }
}
