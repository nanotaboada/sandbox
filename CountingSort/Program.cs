using BenchmarkDotNet.Running;

namespace CountingSort;

class Program
{
    // Comment/Uncomment as needed.
    static void Main(string[] args)
    {
        // DebugConsoleRunner.Run();

        // dotnet run -c Release
        BenchmarkRunner.Run<CountingSortBenchmark>();
    }
}
