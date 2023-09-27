delegate void FunctionToCall(ref int x);

class SomeClass
{
    public void DoSomeThing(ref int x)
    {
        x = 5;
        Console.WriteLine(x);
    }
}

class Program
{
    static void Main()
    {
        int x = 1;
        SomeClass someClass = new SomeClass();
        FunctionToCall ftc = new FunctionToCall(someClass.DoSomeThing);
        ftc(ref x);
    }
}