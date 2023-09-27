class Employee
{
    public int ID { get; private set; } // read-only
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        employee.FirstName = "Test";
        employee.LastName = "Er";
        Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
    }
}