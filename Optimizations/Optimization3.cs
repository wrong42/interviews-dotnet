public static class TestClass
{
    public static void PrintPeopleByCity(IConnection connection)
    {
        var result = string.Empty;
        var cityDict = new Dictionary<string, List<Person>>();

        foreach (var person in connection.GetPersons())
        {
            var cityPeople = cityDict.GetValueOrDefault(person.City);
            
            if (cityPeople is null)
            {
                cityDict.Add(person.City, new List<Person>());
            }

            cityPeople.Add(person);
        }

        foreach (var city in cityDict)
        {
            result += city.Key + ":" + Environment.NewLine;

            foreach (var person in city.Value)
            {
                result += "\t" + person.Name + Environment.NewLine;
            }

            result += Environment.NewLine;
        }
    }
}