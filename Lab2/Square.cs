namespace Lab2;

public class Square: Figure
{
    private double a { get; set; }

    public Square(double a)
    {
        this.a = a;
    }

    public override double GetArea()
    {
        return Math.Pow(a, 2);
    }
}