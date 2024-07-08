using AreaCalculatorService.Interfaces;
using AreaCalculatorService.Shapes;
using AreaCalculatorService.Validators;

namespace AreaCalculatorService;

public class AreaCalculatorService
{
    private readonly Dictionary<Type, IValidator> _validatorsByType = new();
    
    public double CalculateArea(IShape shape)
    {
        if (_validatorsByType.TryGetValue(shape.GetType(), out var validator))
        {
            if (!validator.IsValid(shape))
            {
                throw new ArgumentException("Invalid shape");
            }
        }
        return shape.GetArea();
    }
    
    public AreaCalculatorService AddDefaultValidators()
    {
        _validatorsByType.Add(typeof(Triangle), new TriangleValidator());
        _validatorsByType.Add(typeof(Circle), new CircleValidator());

        return this;
    }

    public AreaCalculatorService AddValidator(Type shapeType, IValidator validator)
    {
        _validatorsByType[shapeType] = validator;

        return this;
    }

    public AreaCalculatorService RemoveValidator(Type shapeType)
    {
        _validatorsByType.Remove(shapeType);

        return this;
    }
}