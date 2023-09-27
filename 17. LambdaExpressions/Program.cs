public delegate int MyDelegate(int n);

class Program
{
    static void Main()
    {
        int n = 2;
        //Using anonymous method
        MyDelegate AnonymousMethod = new MyDelegate(delegate (int n) { return n * 10; });
        Console.WriteLine("Result: {0}", AnonymousMethod(n));

        //Using lambda Expressions
        MyDelegate UsingLambdaE = (int n) => n * 10;
        Console.WriteLine("Result by using Lambda Expression: {0}", UsingLambdaE(n));

    }
}