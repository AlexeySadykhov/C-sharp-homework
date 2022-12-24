// Task 64
void ReversedRange(int n)
{
    if (n >= 1)
    {
        Console.Write($"{n} ");
        ReversedRange(n - 1);
    }
}

Console.WriteLine("Task 64.");
ReversedRange(8);
Console.WriteLine();

// Task 66
int sm = 0;
void SumOfRange(int m, int n)
{
    if (n >= m)
    {
        sm += n;
        SumOfRange(m, n - 1);
    }
}

SumOfRange(1, 15);
Console.WriteLine($"Task 66.\n{sm}");

// Task 68
ulong Ackermann(ulong n, ulong m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ackermann(n - 1, 1);
    return Ackermann(n - 1, Ackermann(n, m - 1));
}

Console.WriteLine($"Task 68.\n{Ackermann(3, 2)}");

// Pascal triangle
void PascalTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        int x = 1;
        for (int j = 0; j < n - i; j++)
        {
            Console.Write("   ");
        }
        for (int j = 0; j < i + 1; j++)
        {
            Console.Write($"   {x}  ");
            x = x * (i - j) / (j + 1);
        }
        Console.WriteLine("\n");
    }
}

Console.WriteLine("Pascal triangle:");
PascalTriangle(10);