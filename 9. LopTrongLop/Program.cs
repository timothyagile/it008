public class Person
{
    public class Date
    {
        private int ngay;
        private int thang;
        public Date()
        {
            this.ngay = 1;
            this.thang = 1;
        }
        public void Xuat()
        {
            Console.WriteLine("Ngay sinh: {0} / {1}", ngay, thang);
        }
    }
    private string Name { get; set; }
    private Date ns;
    public Person()
    {
        Name = "Thinh";
        ns = new Date();
    }
    public void Xuat()
    {
        ns.Xuat();
        Console.WriteLine("Ho ten: {0}", Name);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Xuat();
        Person.Date ns = new Person.Date();
        ns.Xuat();
    }
}