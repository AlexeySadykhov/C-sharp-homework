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

int num = GetNumber("Task 1.\nEnter the number:");
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

Console.WriteLine(SumOfDigits(GetNumber("Task 2.\nEnter the number:")));

// Task 3
int[] CreateArray(int size = 8)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

Console.WriteLine("Task 3.");
Console.WriteLine(string.Join((" "), CreateArray()));