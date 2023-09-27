public class Person
{
    string _Name;
    List<string> _Interests = new List<string>();
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    public List<string> Interests
    {
        get { return _Interests; }
    }
}

public class Program
{
    static void Main()
    {
        List<Person> PersonList = new List<Person> { new Person { Name = "Thinh", Interests = {"Reading", "Coding"},
        }, new Person { Name = "Khoa", Interests = { "Listen", "Swimming"} } };

        foreach (Person p in PersonList)
        {
            Console.WriteLine("\n" + p.Name);
            foreach (string str in p.Interests)
            {
                Console.Write(str + " ");
            }
        }
    }
}