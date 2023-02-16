namespace Lab2;

public class Triangle : Figure
{
    private double a { get; set; }
    private double b { get; set; }
    private double c { get; set; }

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

        public override double GetArea()
    {
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}