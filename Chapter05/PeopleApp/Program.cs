//using Fruit = (string Name, int Number); // Aliasing a typle type
using   Packt.Shared;
//using Dumpify; // To use the Dump extension method.
//ConfigureConsole("es-US");
//Person bob = new Person();
//bob.Name = "Bob Smith";
//bob.Born = new DateTimeOffset(
//    year: 1965, month: 12, day: 22,
//    hour: 16, minute: 28, second: 0,
//    offset: TimeSpan.FromHours(-5));

//Person alice = new Person()
//{
//    Name = "Alice Jones",
//    Born = new(1998, 3, 7, 16, 28, 0,
//    TimeSpan.Zero)
//};

//WriteLine(format: "{0} was born on {1:d}.",
//    arg0: alice.Name, arg1: alice.Born);

//WriteLine(format: "{0} was born on {1:D}.",
//    arg0: bob.Name, arg1:bob.Born);

//bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia | WondersOfTheAncientWorld.GreatPyramidOfGiza;
//bob.FavoriteAncientWonder = (WondersOfTheAncientWorld)128;
//bob.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;
//WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}.",
//    arg0: bob.Name, arg1: bob.FavoriteAncientWonder, arg2: (int)bob.FavoriteAncientWonder);
//bob.BucketList =
//    WondersOfTheAncientWorld.HangingGardensOfBabylon
//    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
//// bob.BucketList = (WondersOfTheAncientWorld(18)
//WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

//Person alfred = new Person();
//alfred.Name = "Alfred";
//bob.Children.Add(alfred);

//bob.Children.Add(new Person { Name = "Bella" });
//bob.Children.Add(new() { Name = "Zoe" });
//WriteLine($"{bob.Name} has {bob.Children.Count} children:");
//for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
//{
//    WriteLine($"> {bob.Children[childIndex].Name}");
//}

//BankAccount.InterestRate = 0.012M;
//BankAccount jonesAccount = new();
//jonesAccount.AccountName = "Mrs. Jones";
//jonesAccount.Balance = 2400;
//WriteLine(format: "{0} earned {1:C} interest.",
//    arg0: jonesAccount.AccountName,
//    arg1: jonesAccount.Balance * BankAccount.InterestRate);
//BankAccount gerrierAccount = new();
//gerrierAccount.AccountName = "Ms. Gerrier";
//gerrierAccount.Balance = 98;
//WriteLine(format: "{0} earned {1:C} interest.",
//    arg0: gerrierAccount.AccountName,
//    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

//// Constant fifelds are accessible via the type
//WriteLine($"{bob.Name} is a {Person.Species}.");

//// Read-only fields are accessible via the variable.
//WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

//bob.Dump(label: "Default output");
//bob.Dump(label: "Include fields and non-public members",
//    members: new MembersConfig
//    {
//        IncludeFields = true,
//        IncludeNonPublicMembers = true
//    });

// * Instiante a book using initializer syntax.
//Book book = new()
//{
//    Isbn = "978-1803237800",
//    Title = "C# 14 and .NET 10 - Modern Cross-Platform Development Fundamentals"
//};
//*/
//Book book = new(isbn: "978-1803237800", title:
//    "C# 14 and .NET 10 - Modern Cross-Platform Development Fundamentals")
//{
//    Author= "Mark J. Price",
//    PageCount= 821
//};
//WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
//    book.Isbn, book, book.Title, book.Author, book.PageCount);

//Person blankPerson = new();
//WriteLine(format:
//    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//    arg0: blankPerson.Name,
//    arg1: blankPerson.HomePlanet,
//    arg2: blankPerson.Instantiated);

//Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
//WriteLine(format:
//    "{0} of {1} was created at {2:hh:mm:ss} on a {2: dddd}.",
//    arg0: gunny.Name,
//    arg1: gunny.HomePlanet,
//    arg2: gunny.Instantiated);
//bob.WriteToConsole();
//WriteLine(bob.GetOrigin());

//int a = 10;
//int b = 20;
//int c = 30;
//int d = 40;
//WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
//bob.PassingParameters(a, b, ref c, out d);
//WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

//int e = 50;
//int f = 60;
//int g = 70;
//WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exists yet!");
//bob.PassingParameters(e, f, ref g, out int h);
//WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

//bob.ParamsParameter("Sum using commas", 3, 6, 1, 2);
//bob.ParamsParameter("Sum using collection expression", [3, 6, 1, 2]);
//bob.ParamsParameter("Sum using explicit array", new int[] { 3, 6, 1, 2 });
//bob.ParamsParameter("Sum (empty)");

//(string, int) fruit = bob.GetFruit();
//WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

//// Without an aliased tuple type.
////var fruitNamed = bob.GetNamedFruit();
//// With an aliased tuple typed.
//Fruit fruitNamed = bob.GetNamedFruit();

//Console.WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

//var thing1 = ("Neville", 4);
//WriteLine($"{thing1.Item1} has {thing1.Item2} children");
//var thing2 = (bob.Name, bob.Children.Count);
//Console.WriteLine($"{thing2.Name} has {thing2.Count} children.");

//(string fruitName, int fruitNumber) = bob.GetFruit();
//Console.WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");

//var (name1, dob1) = bob; // Implicitly calls the Deconstruct method.
//WriteLine($"Deconstructed person: {name1}, {dob1}");
//var (name2, dob2, fav2) = bob;
//Console.WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

//// Change to -1 to make the exception handling code execute.
//int number = 5;
//try
//{
//    Console.WriteLine($"{number}! is {Person.Factorial(number)}");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
//}

//Person sam = new()
//{
//    Name = "Sam",
//    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
//};
//WriteLine(sam.Origin);
//Console.WriteLine(sam.Greeting);
//Console.WriteLine(sam.Age);

//sam.FavoriteIceCream = "Chocolate Fudge";
//Console.WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
//string color = "YYellow";
//try
//{
//    sam.FavoritePrimaryColor = color;
//    Console.WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
//}
//catch (Exception ex) {
//    Console.WriteLine("Tried to set {0} to '{1}': {2}",
//        nameof(sam.FavoritePrimaryColor), color, ex.Message);
//}
//sam.Children.Add(new()
//{
//    Name = "Charlie",
//    Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
//});
//sam.Children.Add(new()
//{
//    Name = "Ella",
//    Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)
//});
//// Get using Children list.
//Console.WriteLine($"Sam's first child child is {sam.Children[0].Name}.");
//Console.WriteLine($"Sam's second child is {sam.Children[1].Name}.");
//// Get using the int indexer.
//Console.WriteLine($"Sam's first child is {sam[0].Name}.");
//WriteLine($"Sam's second child is {sam[1].Name}");
////Get using the string indexer.
//WriteLine($"Sam's child names Ells is {sam["Ella"].Age} years old.");
#region Object Pattern Matching
// An array containing a mix of passenger types.
using Packt.Shared;

///*
Passenger[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419, Name = "Susan"},
    new FirstClassPassenger { AirMiles = 16_564, Name = "Lucy"},
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};
foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        //FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
        //FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
        //FirstClassPassenger _ => 2_000M,
        // C# 9 or later syntax
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M
        },
        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    Console.WriteLine($"Flight costs {flightCost:C} for {passenger}"    );
}
#endregion
#region initonly properties
ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};
//jeff.FirstName = "Geoff";
#endregion
ImmutableVehicule car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};
ImmutableVehicule repaintedCar = car
    with
{ Color = "Polymetal Grey Metallic" };
Console.WriteLine($"Original car color was {car.Color}.");
Console.WriteLine($"New car color is {repaintedCar.Color}.");

AnimalClass ac1 = new() { Name = "Rex" };
AnimalClass ac2 = new() { Name = "Rex" };
Console.WriteLine($"ac1 == ac2: {ac1 == ac2}");
AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };
Console.WriteLine($"ar1 == ar2: {ar1 == ar2}");

int number1 = 3;
int number2 = 3;
Console.WriteLine($"number1: {number1}, number2: {number2}");
Console.WriteLine($"number 1 == number2: {number1 == number2}");

Person p1 = new() { Name = "Kevin" };
Person p2 = new()  { Name = "Kevin" };
Console.WriteLine($"p1: {p1}, p2: {p2}");
Console.WriteLine($"p1.Name: {p1.Name}, p2: {p2.Name}");
Console.WriteLine($"p1 == p2: {p1 == p2}");

Person p3 = p1;
Console.WriteLine($"p3.Name: {p3.Name}");
Console.WriteLine($"p1 == p3: {p1 == p3}");

// string is the only class reference type implemented to
// act like a value type for equality
Console.WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
Console.WriteLine($"p1.Name == p2.Name: {p1.Name == p2.Name}");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar; // calls the deconstruct method.
Console.WriteLine($"{who} is a {what}");

Headset vp = new("Apple", "Vision Pro");
Console.WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}.");