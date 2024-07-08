using AreaCalculatorService.Interfaces;
using AreaCalculatorService.Shapes;

namespace AreaCalculatorService.Validators;

public class CircleValidator : IValidator
{
    public bool IsValid(IShape shape)
    {
        if (shape is Circle circle)
        {
            if (circle.Radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than zero.");
            }
            
            return true;
        }

        return false;
    }
}