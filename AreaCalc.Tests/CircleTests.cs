namespace AreaCalc.Tests;

public class CircleTests
{
    [Fact]
    public void UserCanCreateCircleAndGetItArea()
    {
        var sut = new Circle(3);

        var result = sut.GetArea();
        
        Assert.InRange(result, 28.27, 28.28);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-0.1)]
    public void UserCantCreateCircleWithIvalidRadius(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            var sut = new Circle(radius);
        });
    }
}