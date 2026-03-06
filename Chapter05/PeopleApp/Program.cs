using Fruit = (string Name, int Number); // Aliasing a typle type
using Packt.Shared;
using Dumpify; // To use the Dump extension method.
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

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name, arg1: bob.FavoriteAncientWonder, arg2: (int)bob.FavoriteAncientWonder);
bob.BucketList =
    WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld(18)
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

bob.Children.Add(new Person { Name = "Bella" });
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

// Constant fifelds are accessible via the type
WriteLine($"{bob.Name} is a {Person.Species}.");

// Read-only fields are accessible via the variable.
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

bob.Dump(label: "Default output");
bob.Dump(label: "Include fields and non-public members",
    members: new MembersConfig
    {
        IncludeFields = true,
        IncludeNonPublicMembers = true
    });

/*
 * Instiante a book using initializer syntax.
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 14 and .NET 10 - Modern Cross-Platform Development Fundamentals"
};
*/
Book book = new(isbn: "978-1803237800", title:
    "C# 14 and .NET 10 - Modern Cross-Platform Development Fundamentals")
{
    Author= "Mark J. Price",
    PageCount= 821
};
WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book, book.Title, book.Author, book.PageCount);

Person blankPerson = new();
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2: dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exists yet!");
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

bob.ParamsParameter("Sum using commas", 3, 6, 1, 2);
bob.ParamsParameter("Sum using collection expression", [3, 6, 1, 2]);
bob.ParamsParameter("Sum using explicit array", new int[] { 3, 6, 1, 2 });
bob.ParamsParameter("Sum (empty)");

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

// Without an aliased tuple type.
//var fruitNamed = bob.GetNamedFruit();
// With an aliased tuple typed.
Fruit fruitNamed = bob.GetNamedFruit();

Console.WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children");
var thing2 = (bob.Name, bob.Children.Count);
Console.WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
Console.WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");
