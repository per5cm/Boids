namespace BoidsCore.Library;

public struct Position
{
    public double X;
    public double Y;

    public Position(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public void Move(double x, double y)
    {
        X += x;
        Y += y;
    }

    public double Distance(Position position)
    {
        position.X -= X;
        position.Y -= Y;
        return Math.Sqrt (position.X * position.X + position.Y * position.Y);
    }

    public static Position Normalize(Position vector)
    {
        double length = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        if (length <= 0) return new Position(0, 0);
        return new Position (vector.X / length, vector.Y / length);
    }
}