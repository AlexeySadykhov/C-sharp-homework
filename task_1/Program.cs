// task 1
Console.WriteLine("Enter the first number:");
string strNumA = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string strNumB = Console.ReadLine();

void CompareTwoNums(string numA, string numB)
{
    if (int.TryParse(strNumA, out var x) & int.TryParse(strNumB, out var y))
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
    else
    {
        Console.WriteLine("Can't convert to integer.");
    }
}
CompareTwoNums(strNumA, strNumB);