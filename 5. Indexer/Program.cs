public class Database
{
    public Dictionary<string, Dictionary<string, double>> Marks = new Dictionary<string, Dictionary<string, double>>();
    public Database() { }
    public double GetMarks(string StudentID, string SubjectID)
    {
        if (Marks.ContainsKey(StudentID) && Marks[StudentID].ContainsKey(SubjectID))
            return Marks[StudentID][SubjectID];
        else
            return 0.0;
    }
    public void UpdateMarks(string StudentID, string SubjectID, double value)
    {
        if (!Marks.ContainsKey(StudentID))
        {
            Marks[StudentID] = new Dictionary<string, double>();
        }
        Marks[StudentID][SubjectID] = value;
    }
}


class Student
{

    protected string StudentID;
    protected Database MarkDB;
    public Student(string StudentID, Database dtb)
    {
        this.StudentID = StudentID;
        MarkDB = dtb;
    }
    public double Marks(string SubjectID)
    {
        return MarkDB.GetMarks(this.StudentID, SubjectID);
    }
    public void Marks(string SubjectID, double value)
    {
        MarkDB.UpdateMarks(this.StudentID, SubjectID, value);
    }
    public double this[string SubjectID]
    {
        get { return Marks(SubjectID); }
        set { Marks(SubjectID, value); }
    }
}

public class Program
{
    static void Main()
    {
        Database db = new Database();
        Student s = new Student("thinh", db);
        s.Marks("physic", 9);
        Console.WriteLine(s["physis"]);
    }
}