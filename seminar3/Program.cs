// Task 1
bool IsPalindrome(string x)
{
    string y = new string(x.Reverse().ToArray());
    if (x == y) return true;
    else return false;
}
// Или вот вариант математикой:
bool IsPal(int num)
{
    int r = 0;
    int sm = 0;
    int t = 0;
    for (t = num; num != 0; num = num/10)
    {
        r = num % 10;
        sm = sm * 10 + r;
    }
    if (t == sm) return true;
    else return false;
}

Console.Write("Task 1\nEnter the number:");
string number = Console.ReadLine();
if (!int.TryParse(number, out var num))
{
    Console.WriteLine($"{number} is not a number.");
}
else
{
    Console.WriteLine(IsPalindrome(number));
    Console.WriteLine(IsPal(num));
}

// Task 2
double FindDistance(int[] left, int[] right)
{
    double result = 0;
    for (int i = 0; i < left.Length; i++)
    {
        result += Math.Pow(left[i] - right[i], 2);
    }
    return Math.Sqrt(result);
}

try
{
    Console.Write("Task 2\nEnter first point coordinates (x, y, z) splitting values by space:");
    var firstPointCoords = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
    Console.WriteLine("Enter second point coordinates (x, y, z) splitting values by space:");
    var secondPointCoords = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
    if (firstPointCoords.Length != 3 || secondPointCoords.Length != 3)
    {
    Console.WriteLine("Error. Your input is incorrect.");
    }
    else
    {
    Console.WriteLine(FindDistance(firstPointCoords, secondPointCoords));
    }
}
catch
{
    Console.WriteLine("Error. Your input is incorrect.");
}

// Task 3
void CubeRange(int x)
{
    if (x <= 1)
    {
        Console.WriteLine("Error. Number must be higher than 1.");
    }
    else
    {
        List<double> nums = new List<double>();
        for (int i = 1; i <= x; i++)
        {
            nums.Add(Math.Pow(i, 3));
        }
        var result = string.Join(" ", nums);
        Console.WriteLine(result);
    }
}

Console.Write("Task 3\nEnter the number:");
int n = Convert.ToInt32(Console.ReadLine());
CubeRange(n);