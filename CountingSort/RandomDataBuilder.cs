namespace CountingSort;

public static class RandomDataBuilder
{
    public static int[] CreateArrayOf(int quantity)
    {
        if (quantity <= 0) throw new ArgumentOutOfRangeException();

        var numbers = new List<int>(quantity);
        var random = new Random();

        for (int i = 0; i < quantity; i++)
        {
            numbers.Add(random.Next(0, quantity));
        }

        return numbers.ToArray();
    }
}