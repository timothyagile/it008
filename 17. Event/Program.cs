public delegate void TextChanged(string name);

class Person
{
    public event TextChanged DoSomeThing
    {
        add { Console.WriteLine("Event added"); }
        remove { Console.WriteLine("Event removed"); }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.DoSomeThing += P_DoSomeThing; // anonymous method
        p.DoSomeThing -= P_DoSomeThing;
    }

    private static void P_DoSomeThing(string name)
    {
        Console.WriteLine("Event called");
    }
}