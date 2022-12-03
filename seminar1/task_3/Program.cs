bool isEven (int x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Enter number:");
string num = Console.ReadLine();
int n = Convert.ToInt32(num);
Console.WriteLine(isEven(n));