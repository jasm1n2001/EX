namespace task3.Classes;

public class Shape
{
    protected  Color _color;
    protected bool _filled=true;

    public Shape(Color color)
    {
        _color = color;
    } 

    public Shape(Color _color, bool filled)
    {
        _color = color;
        _filled = filled;
    }
     public enum GetColor()
     {
        return _color;

     }

    public enum SetColor(Color color)
     {
        _color = color;
        
     }

     public abstract double GetArea()
     {
        return 2+4;
     }

     public abstract double GetParimeter()
     {
        return 5+4;
     }

     public abstract string ToSring()
     {
        return $"Shape {_color} filled {_filled}"
     }
    

}


 public enum Color
 {
    Red = 1;
    Black =2;
 }
