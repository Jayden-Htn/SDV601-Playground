public class Animal
{
    private string _name;

    public Animal()
    {
        _name = string.Empty;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Mode()
    {
        return "The animal sound";
    }
}