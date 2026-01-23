class Animal // this is the base type for all the animals.
{
    public string? Name;
    public DateTime Born;
    public byte Legs;
}
class Cat : Animal
{
    public bool IsDomestic;
}
class Spider: Animal
{
    public bool IsPoisonous;
}