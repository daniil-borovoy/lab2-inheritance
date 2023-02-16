namespace Lab2;

public class RegularDecagon : Figure
{
    private double a { get; set; }

    public RegularDecagon(double a)
    {
        this.a = a;
    }
    
    public override double GetArea()
    {
        return (double)5 / 2 * Math.Pow(a, 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
    }
}