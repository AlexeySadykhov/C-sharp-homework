// Task 1
bool IsPalindrome(string x)
{
    string y = new string(x.Reverse().ToArray());
    if (x == y) return true;
    else return false;
}
Console.WriteLine("Enter the number:");
string number = Console.ReadLine();
if (!int.TryParse(number, out var num))
{
    Console.WriteLine($"{number} is not a number.");
}
else Console.WriteLine(IsPalindrome(number));