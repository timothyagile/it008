public class PhanSo
{
    private int tu { get; set; }
    private int mau { get; set; }
    public PhanSo(int tu, int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }

    public static bool operator ==(PhanSo a, PhanSo b)
    {
        return (float)a.tu / a.mau == (float)b.tu / b.mau;
    }
    public static bool operator !=(PhanSo a, PhanSo b)
    {
        return (float)a.tu / a.mau != (float)b.tu / b.mau;
    }
}

public class Program
{
    static void Main()
    {
        PhanSo a = new PhanSo(2, 3);
        PhanSo b = new PhanSo(5, 6);
        if (a == b)
            Console.WriteLine("True");
        else
        {
            Console.WriteLine("False");
        }
    }
}