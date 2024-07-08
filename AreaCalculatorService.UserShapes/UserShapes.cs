using AreaCalculatorService.UserShapes.Shapes;
using AreaCalculatorService.UserShapes.Validators;

namespace AreaCalculatorService.UserShapes;

public class UserShapes
{
    private AreaCalculatorService _areaCalculatorService = new();

    public void Launch()
    {
        _areaCalculatorService.AddValidator(typeof(Rectangle), new RectangleValidator());
        _areaCalculatorService.CalculateArea(new Rectangle(2, 3));
    }
}