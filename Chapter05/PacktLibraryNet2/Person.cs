namespace Packt.Shared;
public class Person : Object
{
    #region Fields: Ddata or state ofr this person.
    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    public const string Species = "Homo Sapiens";
    // readonly fields: values that can be set at runtime.
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    #endregion
    #region
    public Person()
    {
        // Constructors can set default values for fields
        // including any read-only fields like Instantiated.
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    #endregion
    #region Methods: Actions the type can perform.
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }
    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out parameters cannot have a default and they
        // must be initialized the method
        z = 100;
        // Increment each parameter excet the read-only x.
        w++;
        //x++; // Gives a complie error!
        y++;
        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }
    public void ParamsParameter(
        string text, params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        WriteLine($"{text}:{total}");
    }
    #endregion
    //Method that returns a tuple: (string, int).
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }
    public (string Name, int Number) GetNamedFruit()
    {
        return ("Apples", 5);
    }
    // Deconstructores: Break down this object into parts.
    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }
}