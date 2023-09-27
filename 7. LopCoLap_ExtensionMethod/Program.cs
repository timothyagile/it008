sealed class Person
{
    public string Name { get; set; }
}

static class Ultility
{
    static public void ExtensionMethod(this Person person)
    {
        person.Name = "Thinh";
        Console.WriteLine("Name: {0}", person.Name);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.ExtensionMethod();
    }
}