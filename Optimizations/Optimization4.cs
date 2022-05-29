public interface IConnection
{
    Task<double> GetPrice(Guid itemId);
}

public class TestClass
{
    private readonly IConnection _connection;

    public async Task<double> CalculateTotalPrice(IEnumerable<Guid> itemIds)
    {
        var total = 0D;
        
        foreach (var itemId in itemIds)
        {
            total += await _connection.GetPrice(itemId);
        }
        
        return total;
    }
}
