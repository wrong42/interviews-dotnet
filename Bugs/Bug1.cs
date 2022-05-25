public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

public interface IConnection
{
    IEnumerable<Person> GetPersons();
}

public class TestClass
{
  public static void PrintPeopleFromPrague(IConnection connection)
  {
      var people = connection.GetPersons();

      foreach (var person in people)
      {
          if (person.Address.Contains("Praha"))
          {
              Console.WriteLine($"{person.Name} is from Prague!");
          }
      }
  }
}