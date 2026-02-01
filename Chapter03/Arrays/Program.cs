string[] names; //This can reference any size array of string
// Allocate memory for four string in an array
names = new string[4];
string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };
// Store items at these index positions.
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
// Loop through the names.
for (int i = 0; i < names2.Length; i++)
{
    WriteLine($"{names2 [i]} is at index {i}.");
}

#region MultiDimensional Arrays
string[,] grid1 = // two dimensiona array.
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};
// Discover the lower and upper bounds of this array
WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");
// for statement to loop through the string values
for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}
#endregion
#region Alternative Syntaxis to ArrayDelcaration
string[,] grid2 = new string[3, 4]; // Allocate memory
grid2[0, 0] = "Alpha";
grid2[0, 1] = "Beta";
// and do son
grid2[2, 3] = "Dog";
#endregion
#region Jagged array
// C# 11 and earlier must use curly braces and new[] expressions.
string[][] jagged = // An array of string arrays.
{
    new[] { "Alpha", "Beta", "Gamma"},
    new[] { "Anne", "Ben", "Charlie", "Doug" },
    new[] { "Aardvark", "Bear" }
};
/*
 * C# 12 and later can use colletion that use square brackets.
 * string[][] jagged = // An array of string arrays.
 * [
 *  ["Alpha", "Beta", "Gamma"],
 *  [ "Anne", "Ben", "Charlie", "Doug" ],
 *  [ "Aadvark", "Bear" ]
 * ]
 */

#endregion

#region List Pattern Match
int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = { 1, 2 };
int[] oneTwoTenNumbers = { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = { }; // Or use Array.Empty<int>()
int[] threeNumbers = { 9, 7, 5 };
int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };
WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
    [] => "Empty array",
    [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
    [1, 2, .., 10] => "Containes 1, 2, any range including empty, 10.",
    [1, 2] => "Contains 1 then 2.",
    [int item1, int item2, int item3] =>
        $"Contains {item1} then {item2} then {item3}.",
    [0, _] => "Starts with 0, then one other number.",
    [0, ..] => "Starts with 0, then any range of numbers.",
    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
    [..] => "Any items in any order.",
};
#endregion