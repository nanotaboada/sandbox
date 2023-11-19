using System.Text;
using BenchmarkDotNet.Attributes;

namespace CountingSort;

[MemoryDiagnoser]
public class CountingSortBenchmark
{
    [Benchmark]
    public void Execute()
    {
        var sorted = CountingSort.Sort(RandomDataBuilder.CreateArrayOf(10000));
    }

}