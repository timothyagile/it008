class SomeClass
{
    public SomeClass(int Value)
    {
        value = Value;
    }

    private int value { get; set; }
    public override string ToString()
    {
        return value.ToString();
    }
}

class Program
{
    static void Main()
    {
        int i = 5;
        Console.WriteLine(i.ToString());
        SomeClass s = new SomeClass(7);
        Console.WriteLine(s.ToString());
        Console.WriteLine(5.ToString());
    }
}