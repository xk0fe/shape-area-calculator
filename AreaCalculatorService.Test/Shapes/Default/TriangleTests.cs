using AreaCalculatorService.Shapes;
using Xunit;

namespace AreaCalculatorService.Test.Shapes.Default;

public class TriangleTests
{
    private readonly AreaCalculatorService _areaCalculator;

    public TriangleTests()
    {
        _areaCalculator = new AreaCalculatorService().AddDefaultValidators();
    }
    
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(8, 15, 17, 60)]
    [InlineData(7, 24, 25, 84)]
    public void CalculateArea_Triangle_ReturnsCorrectArea(double sideA, double sideB, double sideC, double expectedArea)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        var area = _areaCalculator.CalculateArea(triangle);

        // Assert
        Assert.Equal(expectedArea, area);
    }
    
    [Theory]
    [InlineData(1, 2, 10)]
    [InlineData(-1, 2, 4)]
    [InlineData(0, 0, 0)]
    [InlineData(4, 3, 8)]
    public void Triangle_CalculateArea_WithInvalidSides_ThrowsException(double sideA, double sideB, double sideC)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _areaCalculator.CalculateArea(triangle));
    }
}