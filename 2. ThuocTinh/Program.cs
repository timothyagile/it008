public class Person
{
    protected int age;
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            else
                age = value;
        }
    }
    protected string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length > 100)
            {
                throw new InvalidOperationException();
            }
            else
                name = value;
        }
    }

    public Person(int num, string str)
    {
        this.Age = num;
        this.Name = str;
    }
}

public class Program
{
    static void Main()
    {
        Person p = new Person(18, "Thinh");
        Console.WriteLine("Thong tin: {0}, {1}", p.Age, p.Name);
        p.Age = 19;
        Console.WriteLine("Thong tin: {0}, {1}", p.Age, p.Name);
    }
}