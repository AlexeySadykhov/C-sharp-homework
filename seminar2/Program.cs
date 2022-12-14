// Tasks 1 and 2
int FindDigit(int n, int d)
{
    if (n < 0) n = n * (-1);
    List<int> remain = new List<int>();
    while (n > 0)
    {
        remain.Add(n % 10);
        n /= 10;
    }
    if (remain.Count < d) return -1;
    else return remain[remain.Count - d];
}

void Main()
{
    Console.Write("Tasks 1-2.\nEnter the number:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the digit you want to find:");
    int digit = Convert.ToInt32(Console.ReadLine());
    int result = FindDigit(number, digit);
    if (result < 0) Console.WriteLine($"Number has no {digit} digit.");
    else Console.WriteLine(result);
}
Main();

// Task 3
bool IsWeekday(int n)
{
    if (n == 6 || n == 7) return true;
    else return false;
}

void Check()
{
    Console.Write("Task 3.\nEnter the number of the day:");
    int dayNum = Convert.ToInt32(Console.ReadLine());
    if (dayNum < 1 || dayNum > 7) Console.WriteLine($"There is no {dayNum} day in the week.");
    else Console.WriteLine(IsWeekday(dayNum));
}
Check();