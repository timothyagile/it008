public class Program
{
    static dynamic Sum(dynamic a, dynamic b)
    {
        return a + b;
    }
    static void Main()
    {
        Console.WriteLine(Sum(5, 2));
        Console.WriteLine(Sum(4.2, 1.2));
    }
}