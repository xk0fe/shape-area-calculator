using AreaCalculatorService.Shapes;
using Xunit;

namespace AreaCalculatorService.Test.Shapes.Default;

public class CircleTests
{
    private readonly AreaCalculatorService _areaCalculator;

    public CircleTests()
    {
        _areaCalculator = new AreaCalculatorService().AddDefaultValidators();
    }
    
    [Fact]
    public void CalculateArea_Circle_ReturnsCorrectArea()
    {
        // Arrange
        var circle = new Circle(5);

        // Act
        var area = _areaCalculator.CalculateArea(circle);

        // Assert
        Assert.Equal(Math.PI * 25, area, 2);
    }
    
    [Theory]
    [InlineData(-100)]
    [InlineData(0)]
    public void Circle_CalculateArea_WithInvalidSides_ThrowsException(double radius)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _areaCalculator.CalculateArea(circle));
    }
}