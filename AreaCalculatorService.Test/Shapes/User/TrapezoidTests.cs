using AreaCalculatorService.UserShapes.Shapes;
using AreaCalculatorService.UserShapes.Validators;
using Xunit;

namespace AreaCalculatorService.Test.Shapes.User;

public class TrapezoidTests
{
    private readonly AreaCalculatorService _areaCalculatorService;

    public TrapezoidTests()
    {
        _areaCalculatorService = new AreaCalculatorService().AddValidator(typeof(Trapezoid), new TrapezoidValidator());
    }
    
    [Fact]
    public void Trapezoid_ShouldCalculateAreaCorrectly()
    {
        // Arrange
        var shape = new Trapezoid(3, 5, 2);
        
        // Act
        var area = _areaCalculatorService.CalculateArea(shape);
        
        // Assert
        Assert.Equal(8, area);
    }
    
    [Theory]
    [InlineData(-3, 5, 2)]
    [InlineData(3, -5, 2)]
    [InlineData(3, 5, -2)]
    [InlineData(0, 0, 0)]
    public void Trapezoid_CalculateArea_WithInvalidSides_ThrowsException(double sideA, double sideB, double sideC)
    {
        // Arrange
        var shape = new Trapezoid(sideA, sideB, sideC);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _areaCalculatorService.CalculateArea(shape));
    }
}