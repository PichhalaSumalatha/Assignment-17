using System;

public class shape
{
    public string ShapeType { get; set; }

    public virtual double Area
    {
        get { return 0; }
    }

    public virtual double Perimeter
    {
        get { return 0; }
    }
}
