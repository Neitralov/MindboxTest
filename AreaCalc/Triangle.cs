namespace AreaCalc;

public class Triangle : IShape
{
    private double A { get; }
    private double B { get; }
    private double C { get; }

    public Triangle(double a, double b, double c)
    {
        const double tolerance = 0.01;
        if (a + b <= c + tolerance || a + c <= b + tolerance || b + c <= a + tolerance)
            throw new ArgumentException("Треугольник с такими сторонами не существует");
        
        A = a; B = b; C = c;
    }
    
    public double GetArea()
    {
        var halfP = (A + B + C) / 2;
        return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
    }

    public bool IsRightAngled()
    {
        var sides = new List<double> { A, B, C };
        var longestSide = sides.Max();
        sides.Remove(longestSide);
        var (firstSmallSide, secondSmallSide) = (sides[0], sides[1]);

        const double tolerance = 0.1;
        var squareOfLongestSide = Math.Pow(longestSide, 2);
        var sumOfSuaresOfOtherSides = Math.Pow(firstSmallSide, 2) + Math.Pow(secondSmallSide, 2);
        return Math.Abs(squareOfLongestSide - sumOfSuaresOfOtherSides) < tolerance;
    }
}