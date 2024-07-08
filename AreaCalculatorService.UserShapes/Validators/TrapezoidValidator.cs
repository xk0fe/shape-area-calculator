using AreaCalculatorService.Interfaces;
using AreaCalculatorService.UserShapes.Shapes;

namespace AreaCalculatorService.UserShapes.Validators;

public class TrapezoidValidator : IValidator
{
    public bool IsValid(IShape shape)
    {
        if (shape is Trapezoid trapezoid)
        {
            if (trapezoid.SideA <= 0)
            {
                throw new ArgumentException("SideA must be greater than zero.");
            }
            
            if (trapezoid.SideB <= 0)
            {
                throw new ArgumentException("SideB must be greater than zero.");
            }
            
            if (trapezoid.Height <= 0)
            {
                throw new ArgumentException("Height must be greater than zero.");
            }
            
            return true;
        }
        return false;
    }
}