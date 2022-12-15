// Task 1
int[] GetArray(string message)
{
    bool isCorrect = false;
    int[] result = Array.Empty<int>();
    while (!isCorrect)
    {
        Console.WriteLine(message);
        try
        {
            result = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            isCorrect = true;
        }
        catch
        {
            Console.WriteLine("Input is incorrect.");
        }
    }
    return result;
}

int PositiveCount(int[] array)
{
    int cnt = 0;
    foreach (int num in array)
    {
        if (num > 0) cnt++;
    }
    return cnt;
}

int[] arr = GetArray("Enter numbers splitting values by space:");
Console.WriteLine($"Count of positive numbers is {PositiveCount(arr)}");

// Task 2
double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else Console.WriteLine("Input is incorrect.");
    }
    return result;
}

(double, double) FindIntersection(double k1, double b1, double k2, double b2)
{
    double x = ((b1 - b2) / (k1 - k2)) * (-1);
    double y = k2 * x + b2;
    return (x, y);
}

double k1 = GetNumber("Enter k1:");
double b1 = GetNumber("Enter b1:");
double k2 = GetNumber("Enter k2:");
double b2 = GetNumber("Enter b2:");
Console.WriteLine(FindIntersection(k1, b1, k2, b2));