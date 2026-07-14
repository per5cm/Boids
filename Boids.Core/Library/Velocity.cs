namespace BoidsCore.Library;

public struct Velocity
{
    public double X;
    public double Y;

    public Velocity(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Speed(double minSpeed, double maxSpeed)
    {
        var currentSpeed = X * X + Y * Y;

        if (currentSpeed <= 0) return;

        // save Math Sqrt when it's needed to save compute.
        if (currentSpeed <= minSpeed * minSpeed)
        {
            currentSpeed = Math.Sqrt(currentSpeed);
            X = (X / currentSpeed) * minSpeed;
            Y = (Y / currentSpeed) * minSpeed;
        }
        else if (currentSpeed >= maxSpeed * maxSpeed)
        {
            currentSpeed = Math.Sqrt(currentSpeed);
            X = (X / currentSpeed) * maxSpeed;
            Y = (Y / currentSpeed) * maxSpeed;
        }
    }
}