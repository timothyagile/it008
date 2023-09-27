public class ThoiGian
{
    public void ThoiGianHienTai()
    {
        Console.WriteLine("Hien thi thoi gian hien hanh \n");
    }
    private int Nam;
    private int Thang;
    private int Ngay;
    private int Gio;
    private int Phut;
    private int Giay;
}

public class Program
{
    static void Main()
    {
        ThoiGian t = new ThoiGian();
        t.ThoiGianHienTai();
    }
}