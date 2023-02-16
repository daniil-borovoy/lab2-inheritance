namespace Lab2;

public class Parallelogram: Figure
{
    private double a { get; set; }
    // TODO: add angle
    private double h { get; set; }

    public Parallelogram(double a, double h)
    {
        this.a = a;
        this.h = h;
    }

    public override double GetArea()
    {
        return a * h;
    }
}