int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else Console.WriteLine("Error. Input is incorrect.");
    }
    return result;
}

// Task 1
int NumberToPow(int x, int n)
{
    int result = 1;
    for (int i = 0; i < n; i++)
    {
        result = result * x;
    }
    return result;
}
// Вообще есть же Math.Pow(), ну да ладно.

Console.WriteLine("Task 1.");
int num = GetNumber("Enter the number:");
int pow = GetNumber("Enter the pow:");
Console.WriteLine(NumberToPow(num, pow));

// Task 2
int SumOfDigits(int x)
{
    int sm = 0;
    while (x > 0)
    {
        sm += x % 10;
        x /= 10;
    }
    return sm;
}

Console.WriteLine("Task 2.");
Console.WriteLine(SumOfDigits(GetNumber("Enter the number:")));

// Task 3
int[] CreateArray(int size = 8, string nums = "")
{
    if (nums.Length == 0)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(0, 100);
        }
        return array;
    }
    else
    {
        return nums.Split(" ").Select(Int32.Parse).ToArray();
    }
}

Console.Write("Task 3.\nEnter the size of array or keep this field empty:");
string arrSize = Console.ReadLine();
Console.Write("If you already have numbers you want to convert, enter them or keep this field empty:");
string numbers = Console.ReadLine();
if (arrSize.Length == 0)
{
    Console.WriteLine(string.Join(" ", CreateArray(nums: numbers)));
}
else
{
    Console.WriteLine(string.Join(" ", CreateArray(size: Convert.ToInt32(arrSize), nums: numbers)));
}