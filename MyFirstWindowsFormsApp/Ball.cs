using System;

public class Ball
{
	public float x, y;
	public float g, speed_x, speed_y;
	public float radius = 30;
	public Ball()
	{

	}

    public Ball(float x, float y, float g, float speed_x, float speed_y)
    {
        this.x = x;
        this.y = y;
        this.g = g;
        this.speed_x = speed_x;
        this.speed_y = speed_y;
    }
	public bool collide(Enemy enemy)
	{
		float x_dif = enemy.x - enemy.width - this.x;
		float y_dif = enemy.y - enemy.height - this.y;
		if (x_dif * x_dif + y_dif * y_dif < radius*radius) {
			return true;
		}
        x_dif = enemy.x - enemy.width - this.x;
        y_dif = enemy.y + enemy.height - this.y;
        if (x_dif * x_dif + y_dif * y_dif < radius * radius)
        {
            return true;
        }
        x_dif = enemy.x + enemy.width - this.x;
        y_dif = enemy.y + enemy.height - this.y;
        if (x_dif * x_dif + y_dif * y_dif < radius * radius)
        {
            return true;
        }
        x_dif = enemy.x + enemy.width - this.x;
        y_dif = enemy.y - enemy.height - this.y;
        if (x_dif * x_dif + y_dif * y_dif < radius * radius)
        {
            return true;
        }
        return false;
	}

	public void Draw(Graphics g)
	{
		g.FillEllipse(Brushes.Aqua, x - radius / 2, y - radius / 2, radius, radius);
	}

    public void Update(float time)
	{
		speed_y -= time * g;
		x += time * speed_x;
		y += time * speed_y;
	}
}
