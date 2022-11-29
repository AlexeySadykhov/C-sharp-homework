// task 2
Console.WriteLine("Enter the first number:");
string strNumA = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string strNumB = Console.ReadLine();
Console.WriteLine("Enter the third number:");
string strNumC = Console.ReadLine();

if (int.TryParse(strNumA, out var numA) & int.TryParse(strNumB, out var numB) & int.TryParse(strNumC, out var numC))
{
    void CompareThreeNums(int x, int y, int z)
    {
        if (x >= y & x >= z)
        {
            Console.WriteLine($"max = {x}");
        }
        else if (y >= x & y >= z)
        {
            Console.WriteLine($"max = {y}");
        }
        else
        {
            Console.WriteLine($"max = {z}");
        }
    }
    CompareThreeNums(numA, numB, numC);

    // А вообще, лучше так сделать:
    int[] numbers = {numA, numB, numC};
    int FindMax(int[] array)
    {
        int maxEl = array[0];
        foreach (int item in array)
        {
            if (item > maxEl)
            {
                maxEl = item;
            }
        }
        return maxEl;
    }
    Console.WriteLine($"max = {FindMax(numbers)}");
}
else
{
    Console.WriteLine("Can't convert to integer.");
}