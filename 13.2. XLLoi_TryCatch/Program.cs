public class Program
{
    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new System.DivideByZeroException();
        if (a == 0)
            throw new System.ArithmeticException();
        return a / b;
    }
    public void Test()
    {
        try
        {
            int a = 5;
            int b = 0;
            Console.WriteLine("a / b = {0}", Divide(a, b));
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine("DivideByZeroException was caught");
        }
        catch (System.ArithmeticException)
        {
            Console.WriteLine("ArithmeticException was caught");
        }
        catch
        {
            Console.WriteLine("Unknown exception was caught");
        }
    }
    static void Main()
    {
        Program p = new Program();
        p.Test();
    }
}