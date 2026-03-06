
public class Rectangle  : Shape
{
    private double _height = 0;
    private double _width = 0;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _height = height;
        _width = width;
    }

    public override double GetArea()
    {
        double area = _height*_width;
        return area;
    }
}