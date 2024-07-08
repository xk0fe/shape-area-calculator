using AreaCalculatorService.Interfaces;

namespace AreaCalculatorService.Shapes;

public class Circle(double radius) : IShape
{
    public double Radius => radius;
    
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}