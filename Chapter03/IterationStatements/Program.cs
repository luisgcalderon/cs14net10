int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

#region Lopping with do statement
//string? actualPassword = "Pa$$word";
//string? password;
//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();
//}
//while (password != actualPassword);
//WriteLine("Correct!");
#endregion

#region for statement
for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}
#endregion

#region forstatement2
for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}
#endregion

#region forloop
List<string> names = ["Adam", "Barry", "Charlie"];
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
#endregion

