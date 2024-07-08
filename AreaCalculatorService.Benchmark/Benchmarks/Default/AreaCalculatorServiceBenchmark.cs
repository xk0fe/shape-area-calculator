using AreaCalculatorService.Shapes;
using AreaCalculatorService.Validators;
using BenchmarkDotNet.Attributes;

namespace AreaCalculatorService.Benchmark.Benchmarks.Default;

public class AreaCalculatorServiceBenchmark
{
    private AreaCalculatorService _areaCalculatorService;
    private Circle _circle;
    private Triangle _triangle;

    [IterationSetup]
    public void Setup()
    {
        _areaCalculatorService = new AreaCalculatorService().AddDefaultValidators();
    }
    
    [Benchmark]
    public double Benchmark_CalculateArea_Circle()
    {
        return _areaCalculatorService.CalculateArea(_circle);
    }
    
    [Benchmark]
    public double Benchmark_CalculateArea_Triangle()
    {
        return _areaCalculatorService.CalculateArea(_triangle);
    }
    
    [Benchmark]
    public void Benchmark_AddValidator_Triangle()
    {
        _areaCalculatorService.AddValidator(typeof(Triangle), new TriangleValidator());
    }
    
    [Benchmark]
    public void Benchmark_RemoveValidator_Shape()
    {
        _areaCalculatorService.RemoveValidator(typeof(Triangle));
    }
}