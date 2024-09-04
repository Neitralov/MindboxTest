using System;

namespace AreaCalc;

public class Circle : IShape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Нельзя создать круг без радиуса");
            
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}