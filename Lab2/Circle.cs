namespace Lab2;

public class Circle: Figure
{
    private double d { get; set; }

    public Circle(double d)
    {
        this.d = d;
    }
    
    public override double GetArea()
    {
        return Math.PI * Math.Pow((d / 2), 2);
    }
}