// task 1
void CompareTwoNums(int x, int y)
{
    if (x > y)
    {
        Console.WriteLine($"max = {x}");
    }
    else
    {
        Console.WriteLine($"max = {y}");
    }
}

Console.WriteLine("Enter the first number:");
string strNumA = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string strNumB = Console.ReadLine();

if (int.TryParse(strNumA, out var numA) & int.TryParse(strNumB, out var numB))
{
    CompareTwoNums(numA, numB);
}
else
{
    Console.WriteLine("Error. Can't convert numbers.");
}