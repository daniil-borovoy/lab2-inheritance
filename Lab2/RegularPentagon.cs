namespace Lab2;

public class RegularPentagon: Figure
{
    private double a { get; set; }

    public RegularPentagon(double a)
    {
        this.a = a;
    }

    public override double GetArea()
    {
        return Math.Pow(a, 2) / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5));
    }

    private double anotherImplementation()
    {
        return 5 * CalculateAreaOfIsoscelesTriangle();
    }
    private double CalculateAreaOfIsoscelesTriangle()
    {
        var b = CalculateSideOfIsoscelesTriangle();
        return 0.5 * a * Math.Sqrt(Math.Pow(b, 2) - Math.Pow(a, 2) / 4);
    }
    
    private double CalculateSideOfIsoscelesTriangle()
    {
        return a / (2 * Math.Sin(Math.PI / 5));
    }
}