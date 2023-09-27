interface IStorable
{
    void Read();
    void Write();
}

public class Document : IStorable
{
    public void Read()
    {
        Console.WriteLine("HellO");
    }
    public void Write() { Console.WriteLine("Hello"); }
}

public class Program
{
    static void Main()
    {
        Document document = new Document();
        document.Read();
        document.Write();
    }
}