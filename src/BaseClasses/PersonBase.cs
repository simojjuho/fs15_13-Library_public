namespace Base;

public abstract class PersonBase
{
    private string _id { get; } = string.Empty;
    private string _name { get; } = string.Empty;
    private string priviledge = string.Empty;

    public string Priviledge
    {
        get
        {
            return priviledge;
        }
    }

    public string Id
    {
        get
        {
            return _id;
        }
    }

    public PersonBase(string name)
    {
        _name = name;
    }
}