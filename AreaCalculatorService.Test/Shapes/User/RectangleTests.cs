using AreaCalculatorService.UserShapes.Shapes;
using AreaCalculatorService.UserShapes.Validators;
using Xunit;

namespace AreaCalculatorService.Test.Shapes.User;

public class RectangleTests
{
    private readonly AreaCalculatorService _areaCalculatorService;
    
    public RectangleTests()
    {
        _areaCalculatorService = new AreaCalculatorService().AddValidator(typeof(Rectangle), new RectangleValidator());
    }
    
    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(3, 5, 15)]
    [InlineData(5, 6, 30)]
    public void Rectangle_ShouldCalculateAreaCorrectly(double width, double height, double expectedArea)
    {
        // Arrange
        var shape = new Rectangle(width, height);
        
        // Act
        var area = _areaCalculatorService.CalculateArea(shape);
        
        // Assert
        Assert.Equal(expectedArea, area);
    }
    
    [Theory]
    [InlineData(-3, 4)]
    [InlineData(3, -4)]
    [InlineData(0, 0)]
    public void Rectangle_CalculateArea_WithInvalidSides_ThrowsException(double width, double height)
    {
        // Arrange
        var shape = new Rectangle(width, height);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _areaCalculatorService.CalculateArea(shape));
    }
    
    [Theory]
    [InlineData(2, 2, true)]
    [InlineData(8, 8, true)]
    [InlineData(0, 0, true)]
    [InlineData(4, 2, false)]
    [InlineData(3, 7, false)]
    public void Rectangle_CalculateArea_IsSquare(double width, double height, bool isSquare)
    {
        // Arrange
        var shape = new Rectangle(width, height);
        
        // Act & Assert
        Assert.True(shape.IsSquare() == isSquare);
    }
}