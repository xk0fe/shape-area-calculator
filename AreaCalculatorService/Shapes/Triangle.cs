using AreaCalculatorService.Interfaces;

namespace AreaCalculatorService.Shapes;

public class Triangle(double sideA, double sideB, double sideC) : IShape
{
    public double SideA => sideA;
    public double SideB => sideB;
    public double SideC => sideC;
    
    public double GetArea()
    {
        var semiperimeter = (sideA + sideB + sideC) / 2;

        return Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
    }
}