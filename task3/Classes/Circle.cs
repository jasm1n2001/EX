namespace task3.Classes;

public class Circle : Shape
{
     double _radius;

    public Circle()
    {

    }
    public Circle(double radius) 
    {
        _radius = radius;
    }

    public Circle(double radius, enum color, bool filled ) 
    {
        _radius = radius;
        _color = color;
        _filled = filled;
    }

    public double GetRadius()
    {
        return _radius;
    }


    public override double GetPerimeter()
    {
        return 2 * 3.14 * _radius;
    }
    public override double GetArea()
    {
        return 3.14 * (_radius *_radius);
    }


    public override string ToSring()
    {
        return $"Circle {}"
    }
}
