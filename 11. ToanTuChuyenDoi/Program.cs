public class PhanSo
{
    private int tu { get; set; }
    private int mau { get; set; }
    public PhanSo(int tu, int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }
    public PhanSo(int theInt)
    {
        this.tu = tu;
        this.mau = 1;
    }
    public static implicit operator PhanSo(int theInt) { return new PhanSo(theInt); }
    public static explicit operator int(PhanSo phanSo) { return phanSo.tu / phanSo.mau; }
    public static bool operator ==(PhanSo a, PhanSo b)
    {
        return (float)a.tu / a.mau == (float)b.tu / b.mau;
    }
    public static bool operator !=(PhanSo a, PhanSo b)
    {
        return (float)a.tu / a.mau != (float)b.tu / b.mau;
    }
    public override bool Equals(object? obj)
    {
        if (!(obj is PhanSo))
            return false;
        else
            return this == (PhanSo)obj;
    }
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        int x = a.tu * b.mau + b.tu * a.mau;
        int y = a.mau * b.mau;
        while (x != y)
        {
            if (x > y)
                x -= y;
            else
                y -= x;
        }
        return new PhanSo((a.tu * b.mau + b.tu * a.mau) / x, (a.mau * b.mau) / x);
    }
    public override string ToString()
    {
        return tu + "/" + mau;
    }
}

public class Program
{
    static void Main()
    {
        PhanSo f1 = new PhanSo(3, 4);
        Console.WriteLine("f1:{0}", f1.ToString());
        PhanSo f2 = new PhanSo(2, 4);
        Console.WriteLine("f2:{0}", f2.ToString());
        PhanSo f3 = f1 + f2;
        Console.WriteLine("f1 + f2 = f3:{0}", f3.ToString());
        PhanSo f4 = f3 + 5;
        Console.WriteLine("f4 = f3 + 5:{0}", f4.ToString());
        PhanSo f6 = 5 + f3;
        Console.WriteLine("f6 = 5 + f3:{0}", f6.ToString());
        PhanSo f5 = new PhanSo(2, 4);
        if (f5 == f2)
        {
            Console.WriteLine("f5:{0}==f2:{1}", f5.ToString(),
            f2.ToString());
        }
    }
}