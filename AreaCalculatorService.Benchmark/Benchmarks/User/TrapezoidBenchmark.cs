using AreaCalculatorService.UserShapes.Shapes;
using BenchmarkDotNet.Attributes;

namespace AreaCalculatorService.Benchmark.Benchmarks.User;

public class TrapezoidBenchmark
{
    private Trapezoid _trapezoid;

    [GlobalSetup]
    public void Setup()
    {
        _trapezoid = new Trapezoid(4, 5, 2);
    }

    [Benchmark]
    public double Benchmark_GetArea()
    {
        return _trapezoid.GetArea();
    }
}