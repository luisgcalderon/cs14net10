using Packt.Shared;
ConfigureConsole("es-US");
Person bob = new Person();
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5));
Person alice = new Person()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.",
    arg0: alice.Name, arg1: alice.Born);
WriteLine(format: "{0} was born on {1:D}.",
    arg0: bob.Name, arg1:bob.Born);