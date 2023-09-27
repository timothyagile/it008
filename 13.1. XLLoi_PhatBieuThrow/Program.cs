public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter main...");
        Program p = new Program();
        p.Func1();
        Console.WriteLine("Exit main...");
    }
    public void Func1()
    {
        Console.WriteLine("Entor func1");
        Func2();
        Console.WriteLine("Exit func1");
    }
    public void Func2()
    {
        Console.WriteLine("Enter func2");
        throw new System.Exception();
        Console.WriteLine("Exit func2");
    }
}