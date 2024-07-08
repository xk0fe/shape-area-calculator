using AreaCalculatorService.Benchmark.Benchmarks.Default;
using AreaCalculatorService.Benchmark.Benchmarks.User;
using BenchmarkDotNet.Running;

namespace AreaCalculatorService.Benchmark;

public class Benchmark
{
    public Benchmark()
    {
        // default benchmarks
        var circleBenchmark = BenchmarkRunner.Run<CircleBenchmark>();
        var triangleBenchmark = BenchmarkRunner.Run<TriangleBenchmark>();
        
        // user benchmarks
        var rectangleBenchmark = BenchmarkRunner.Run<RectangleBenchmark>();
        var trapezoidBenchmark = BenchmarkRunner.Run<TrapezoidBenchmark>();
    }
}