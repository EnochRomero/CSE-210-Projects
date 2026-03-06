
public class Square : Shape
{
    private double _side = 0;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        double area = _side*2;
        return area;
    }
}