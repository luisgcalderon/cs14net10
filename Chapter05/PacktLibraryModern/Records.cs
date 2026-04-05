namespace Packt.Shared;
public class ImmutablePerson
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public record ImmutableVehicule
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; } 
}
// Simpler syntax to define a record that auto-generates the 
// properties, constructors, and deconstructors
public record ImmutableAnimal(string Name, string Species);