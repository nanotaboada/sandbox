using System.Text;

namespace CountingSort;

public static class DebugConsoleRunner
{
    public static void Run()
    {
            var numbers = RandomDataBuilder.CreateArrayOf(42);
            var sorted = CountingSort.Sort(numbers);
        
            var output = new StringBuilder();

            output.AppendLine("Random");
            output.Append("[ ");
            numbers.ToList().ForEach(number => output.AppendFormat("{0} ", number));
            output.Append("]");

            output.AppendLine();
            output.AppendLine("Sorted");
            output.Append("[ ");
            sorted.ToList().ForEach(number => output.AppendFormat("{0} ", number));
            output.Append("]");

            Console.WriteLine(output.ToString());
    }
}