using AreaCalculatorService.Shapes;
using BenchmarkDotNet.Attributes;

namespace AreaCalculatorService.Benchmark.Benchmarks.Default;

public class CircleBenchmark
{
    private Circle _circle;

    [GlobalSetup]
    public void Setup()
    {
        _circle = new Circle(10);
    }
    
    [Benchmark]
    public double Benchmark_GetArea_Circle()
    {
        return _circle.GetArea();
    }
}