using AreaCalculatorService.Interfaces;

namespace AreaCalculatorService.UserShapes.Shapes;

public class Rectangle(double width, double height) : IShape
{
    public double Width => width;
    public double Height => height;

    public bool IsSquare()
    {
        return width == height;
    } 

    public double GetArea()
    {
        return width * height;
    }
}