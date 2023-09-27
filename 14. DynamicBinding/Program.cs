public class Person
{
    public void Swim()
    {
        Console.WriteLine("Person is swimming");
    }
}

public class Duck
{
    public void Swim()
    {
        Console.WriteLine("Duck is swimming");
    }
}

public class Program
{
    static void InvokeSwim(dynamic obj)
    {
        obj.Swim();
    }
    static void Main()
    {
        dynamic p = new Person();
        dynamic d = new Duck();
        Program pr = new Program();
        InvokeSwim(p);
        InvokeSwim(d);
    }
}