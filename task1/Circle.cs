namespace task1;

public class Circle
{
    public double _radius { get; set; }
    public const Pi = 3.14;



    public Circle()
    {

    }

    public Circle(double radius)
    {
        _radius = radius;
    }

    public  double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public void GetArea()
    {
        return Pi * _radius * _radius;
    }
     
    public double GetCircumference()
    {
        return 2*Pi*_radius;
    }

    public override  string ToSring()
    {
        return $" Circle: {_radius} "
    }


 
}
