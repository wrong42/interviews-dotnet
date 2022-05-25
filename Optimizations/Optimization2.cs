  public class Person
  {
      public int Age { get; set; }
      public string Name { get; set; }
  }

  public interface IConnection
  {
      IEnumerable<Person> GetPersons();
  }

  public class TestClass
  {
    public static void PrintPeopleInTheirTwenties(IConnection connection)
    {
        var persons = connection.GetPersons();

        Console.WriteLine($"Found {persons.Count()} persons.");

        var inTheirTwenties = persons.Where(p => p.Age > 19 && p.Age < 30);

        Console.WriteLine($"Found {inTheirTwenties.Count()} persons in their twenties.");

        foreach (var person in inTheirTwenties)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
  }