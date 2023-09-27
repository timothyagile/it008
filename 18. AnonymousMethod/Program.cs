public delegate void EventHandler();

public class Person
{

    public event EventHandler DoSomeThing
    {
        add
        {
            Console.WriteLine("Hello");
        }
        remove
        {
            Console.WriteLine("Bye");
        }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.DoSomeThing += delegate ()
        {
            Console.WriteLine("Event called");
        };
    }
}