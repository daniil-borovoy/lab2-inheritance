namespace Lab2;

public class Rhombus: Figure
{
    private double d1 { get; set; }
    private double d2 { get; set; }


    public Rhombus(double d1, double d2)
    {
        this.d1 = d1;
        this.d2 = d2;
    }

    public override double GetArea()
    {
        return (d1 * d2) / 2;
    }
}