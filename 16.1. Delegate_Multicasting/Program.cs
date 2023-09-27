delegate void mDelegate();
public class Person
{
    public void Sound()
    {
        Console.WriteLine("Hello");
    }
}

public class Duck
{
    public void Sound()
    {
        Console.WriteLine("Quack quack");
    }
}

public class Program
{
    static void Main()
    {
        Person person = new Person();
        Duck duck = new Duck();
        mDelegate callFunc = null;
        callFunc += new mDelegate(person.Sound);
        callFunc += new mDelegate(duck.Sound);
        callFunc();
    }
}