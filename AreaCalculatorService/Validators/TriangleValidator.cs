using AreaCalculatorService.Interfaces;
using AreaCalculatorService.Shapes;

namespace AreaCalculatorService.Validators;

public class TriangleValidator : IValidator
{
    public bool IsValid(IShape shape)
    {
        if (shape is Triangle triangle)
        {
            if (triangle.SideA <= 0)
            {
                throw new ArgumentException("SideA must be greater than zero.");
            }
            
            if (triangle.SideB <= 0)
            {
                throw new ArgumentException("SideB must be greater than zero.");
            }
            
            if (triangle.SideC <= 0)
            {
                throw new ArgumentException("SideC must be greater than zero.");
            }
            
            return triangle.SideA + triangle.SideB > triangle.SideC &&
                   triangle.SideA + triangle.SideC > triangle.SideB &&
                   triangle.SideB + triangle.SideC > triangle.SideA;
        }

        return false;
    }
}