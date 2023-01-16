using BenchmarkDotNet.Running;
using StringConcatenation.Benchmarks;

namespace StringConcatenation;

public static class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<StringLiteralsBenchmark>();
    }
}