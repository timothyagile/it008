class Window
{
    private int top;
    private int left;
    public Window(int top, int left)
    {
        this.top = top;
        this.left = left;
    }

    public void DrawWindow()
    {
        Console.WriteLine("DrawWindow at: {0} {1}", top, left);
    }
}

class ListBox : Window
{
    private string mContent;
    public ListBox(int top, int left, string Content) : base(top, left) //ke thua lai 2 thuoc tinh cua lop base
    {
        mContent = Content;
    }
    //tao mot phien ban moi cua ham DrawWindow do muon dinh nghia lai ham
    public new void DrawWindow()
    {
        base.DrawWindow();
        Console.WriteLine("Draw ListBox at: {0}", mContent);
    }
}

class Program
{
    static void Main()
    {
        Window w = new Window(5, 10);
        w.DrawWindow();
        ListBox l = new ListBox(10, 20, "Hello");
        l.DrawWindow();
    }
}