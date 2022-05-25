  public class Person
  {
      public int Age { get; set; }
      public string Name { get; set; }
  }

  public interface IConnection
  {
      IQueryable<Person> GetPersons();
  }

  public class TestClass
  {
    public static void PrintPeopleInTheirTwenties(IConnection connection)
    {
        var persons = connection.GetPersons().ToList();

        var inTheirTwenties = persons.Where(p => p.Age > 19 && p.Age < 30).ToList();

        foreach (var person in inTheirTwenties)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
  }