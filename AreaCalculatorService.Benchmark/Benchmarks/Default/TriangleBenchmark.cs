using AreaCalculatorService.Shapes;
using BenchmarkDotNet.Attributes;

namespace AreaCalculatorService.Benchmark.Benchmarks.Default;

public class TriangleBenchmark
{
    private Triangle _trinagle;

    [GlobalSetup]
    public void Setup()
    {
        _trinagle = new Triangle(3, 5, 7);
    }
    
    [Benchmark]
    public double Benchmark_GetArea_Triangle()
    {
        return _trinagle.GetArea();
    }
}