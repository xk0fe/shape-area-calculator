using AreaCalculatorService.UserShapes.Shapes;
using BenchmarkDotNet.Attributes;

namespace AreaCalculatorService.Benchmark.Benchmarks.User;

public class RectangleBenchmark
{
    private Rectangle _square;
    private Rectangle _rectangle;

    [GlobalSetup]
    public void Setup()
    {
        _square = new Rectangle(10, 10);
        _rectangle = new Rectangle(10, 20);
    }

    [Benchmark]
    public bool Benchmark_IsSquare_Square()
    {
        return _square.IsSquare();
    }

    [Benchmark]
    public bool Benchmark_IsSquare_Rectangle()
    {
        return _rectangle.IsSquare();
    }
    
    [Benchmark]
    public double Benchmark_GetArea_Square()
    {
        return _square.GetArea();
    }

    [Benchmark]
    public double Benchmark_GetArea_Rectangle()
    {
        return _rectangle.GetArea();
    }
}