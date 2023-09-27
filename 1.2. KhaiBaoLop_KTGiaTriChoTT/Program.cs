public class ThoiGian
{
    public void ThoiGianHienTai()
    {
        System.DateTime now = System.DateTime.Now;
        System.Console.WriteLine("Hien thi thoi gian hien hanh: \n \t {0} / {1} / {2}    {3} : {4} : {5}"
        , now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);

        System.Console.WriteLine("Hien thi thoi gian hien hanh: \n \t {0} / {1} / {2}    {3} : {4} : {5}"
        , Ngay, Thang, Nam, Gio, Phut, Giay);
    }

    public ThoiGian(System.DateTime dt)
    {
        Nam = dt.Year; Thang = dt.Month; Ngay = dt.Day;
        Gio = dt.Hour; Phut = dt.Minute; Giay = dt.Second;
    }

    public ThoiGian(int Year, int Month, int Day, int Hour, int Minute, int Second)
    {
        Nam = Year; Thang = Month; Ngay = Day;
        Gio = Hour; Phut = Minute; Giay = Second;

    }

    private int Nam;
    private int Thang;
    private int Ngay;
    private int Gio;
    private int Phut;
    private int Giay;
}

public class Tester
{
    static void Main()
    {
        ThoiGian t1 = new ThoiGian(System.DateTime.Now);
        t1.ThoiGianHienTai();

        ThoiGian t2 = new ThoiGian(2023, 1, 1, 10, 23, 30);
        t2.ThoiGianHienTai();
    }
}