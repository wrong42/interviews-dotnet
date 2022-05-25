public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}

public interface IConnection
{
    IEnumerable<Person> GetPersons();
}

public static class TestClass
{
    public static void PrintUniqueCities(IConnection connection)
    {
        var cities = string.Empty;

        foreach (var person in connection.GetPersons())
        {
            AddCityIfMissing(cities, person.City);
        }

        Console.WriteLine("All cities: " + cities);
    }

    private static void AddCityIfMissing(string cities, string city)
    {
        if (!cities.Contains(city))
        {
            cities += $"{city}, ";
        }
    }
}