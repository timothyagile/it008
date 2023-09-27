using System.Collections;

public class Person
{
    public string f_Name
    { get; private set; }
    public string l_Name
    { get; private set; }
    //Constructor
    public Person(string f, string l)
    {
        f_Name = f;
        l_Name = l;
    }
}

//Using normal return
public class People : IEnumerable
{
    private Person[] _people;

    //Initizalizer
    public People(Person[] p_Array)
    {
        _people = new Person[p_Array.Length];
        for (int i = 0; i < p_Array.Length; i++)
        {
            _people[i] = p_Array[i];
        }
    }

    //Recursion
    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumrator();

    }


    public PeopleEnum GetEnumrator()
    {
        return new PeopleEnum(_people);
    }
}

public class PeopleEnum : IEnumerator
{
    private Person[] _people;
    private int position = -1;
    public PeopleEnum(Person[] list)
    {
        _people = list;
    }
    public bool MoveNext()
    {
        position++;
        return position < _people.Length;
    }
    public void Reset()
    {
        position = -1;
    }
    object IEnumerator.Current => Current;
    public Person Current
    {
        get
        {
            try
            {
                return _people[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

//Using yield return to creating the shotter code and increase the perfomance
//public class People : IEnumerable<Person>
//{
//    private Person[] _people;

//    //Initizalizer
//    public People(Person[] p_Array)
//    {
//        _people = new Person[p_Array.Length];
//        for (int i = 0; i < p_Array.Length; i++)
//        {
//            _people[i] = p_Array[i];
//        }
//    }

//    public IEnumerator<Person> GetEnumerator()
//    {
//        for (int i = 0; i < _people.Length; i++)
//        {
//            yield return _people[i];
//        }
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}

public class Program
{
    static void Main()
    {
        Person[] PeopleArray = new Person[3]
        {
            new Person("Nguyen", "Thinh"),
            new Person("Nguyen", "Tan"),
            new Person ("Nguyen", "An"),
        };
        People list = new People(PeopleArray);
        foreach (Person person in PeopleArray)
        {
            Console.WriteLine("Name: {0} {1}", person.f_Name, person.l_Name);
        }

        PeopleEnum pEnum = list.GetEnumrator();
        pEnum.Reset();
        pEnum.MoveNext();
        Person p = pEnum.Current;
        Console.WriteLine("First Person is: {0} {1}", p.f_Name, p.l_Name);
    }
}