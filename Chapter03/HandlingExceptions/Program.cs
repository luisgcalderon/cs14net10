//WriteLine("Before parsing");
//Write("What is your age?");
//string? input = ReadLine();
//try
//{
//    int age = int.Parse(input);
//    WriteLine($"You are {age} years old.");
//}
//catch (FormatException)
//{
//    WriteLine("The age you enteres is not a valid number format");
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()} says {ex.Message}");
//}
//WriteLine("After parsing");

#region OverFlow
try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caugh the exception.");
}
#endregion