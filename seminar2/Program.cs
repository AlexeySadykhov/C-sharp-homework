// Tasks 1 and 2
int FindDigit(int n, int d)
{
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
    Console.WriteLine("Enter the number:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the digit you want to find:");
    int digit = Convert.ToInt32(Console.ReadLine());
    int result = FindDigit(number, digit);
    if (result < 0) Console.WriteLine($"Number has no {digit} digit.");
    else Console.WriteLine(result);
}
Main();

