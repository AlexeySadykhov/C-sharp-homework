void evenRange(int x)
{
    if (x <= 1)
    {
        Console.WriteLine("Error. Number must be higher than 1.");
    }
    else
    {
        List<int> nums = new List<int>();
        for (int i = 1; i <= x; i++)
        {
            if (i % 2 == 0)
            {
                nums.Add(i);
            }
        }
        var result = string.Join(" ", nums);
        Console.WriteLine(result);
    }
}

Console.WriteLine("Enter number:");
string strNum = Console.ReadLine();
int number = Convert.ToInt32(strNum);
evenRange(number);