namespace AreaCalc.Tests;

public class TriangleTests
{
    [Fact]
    public void UserCanCreateTriangleAndGetItArea()
    {
        var sut = new Triangle(1.5, 2, 2.5);

        var result = sut.GetArea();
        
        Assert.InRange(result, 1.49, 1.51);
    }

    [Theory]
    [InlineData(3, 1, 1)]
    [InlineData(3, 1.5, 1.5)]
    [InlineData(0.1, 0.2, 0.3)]
    public void UserCantCreateInvalidTriangle(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var sut = new Triangle(a, b, c);
        });
    }

    [Theory]
    [InlineData(1.5, 2, 2.5)]
    [InlineData(2, 3, 3.6)]
    public void ThisIsRightAngledTriangle(double a, double b, double c)
    {
        var sut = new Triangle(a, b, c);

        var result = sut.IsRightAngled();
        
        Assert.True(result);
    }

    [Theory]
    [InlineData(2, 1, 2.6)]
    [InlineData(3, 2, 1.6)]
    public void ThisIsNotRightAngledTriangle(double a, double b, double c)
    {
        var sut = new Triangle(a, b, c);

        var result = sut.IsRightAngled();
        
        Assert.False(result);
    }
}