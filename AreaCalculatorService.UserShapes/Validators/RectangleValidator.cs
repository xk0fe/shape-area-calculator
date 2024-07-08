using AreaCalculatorService.Interfaces;
using AreaCalculatorService.UserShapes.Shapes;

namespace AreaCalculatorService.UserShapes.Validators;

public class RectangleValidator : IValidator
{
    public bool IsValid(IShape shape)
    {
        if (shape is Rectangle rectangle)
        {
            if (rectangle.Width <= 0)
            {
                throw new ArgumentException("Width must be greater than zero.");
            }
            
            if (rectangle.Height <= 0)
            {
                throw new ArgumentException("Height must be greater than zero.");
            }
            
            return true;
        }

        return false;
    }
}