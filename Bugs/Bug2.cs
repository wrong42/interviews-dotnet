public static class TestClass
{
    public static async Task PrintNumber()
    {
        await Task.Delay(5000);

        var baseNumber = new Random().Next(1, 100);
        var calculated = LongRunningCalculation();

        if (calculated is null)
        {
            Console.WriteLine(baseNumber);
        }

        Console.WriteLine(calculated);
    }

    private static async Task<int?> LongRunningCalculation()
    {
        await Task.Delay(2000);
        return 5;
    }
}