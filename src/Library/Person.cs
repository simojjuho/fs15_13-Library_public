namespace Library;

public abstract class Person
{
    private string _id { get; } = string.Empty;
    private string _name { get; } = string.Empty;    

    public Person(string name)
    {
        _name = name;
    }
}