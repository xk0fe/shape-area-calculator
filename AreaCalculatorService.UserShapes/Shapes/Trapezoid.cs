using AreaCalculatorService.Interfaces;

namespace AreaCalculatorService.UserShapes.Shapes;

public class Trapezoid(double sideA, double sideB, double height) : IShape
{
    public double SideA => sideA;
    public double SideB => sideB;
    public double Height => height;
    
    public double GetArea()
    {
        return sideA + sideB / 2 * height;
    }
}