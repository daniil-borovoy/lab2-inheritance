namespace Lab2;

public class Trapezoid: Figure
{
    private double a { get; set; }
    private double b { get; set; }
    private double h { get; set; }

    public Trapezoid(double a, double b, double h)
    {
        this.a = a;
        this.b = b;
        this.h = h;
    }
    
    public override double GetArea()
    {
        return 0.5 * (a + b) * h;
    }
}