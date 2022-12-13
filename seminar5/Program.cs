// Task 1
int[] RandomIntegers(int min, int max, int size = 8)
{
    int[] array = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

int EvenCount(int[] nums)
{
    int cnt = 0;
    foreach (int num in nums)
    {
        if (num % 2 == 0) cnt += 1;
    }
    return cnt;
}

int[] array = RandomIntegers(min: 100, max: 999);
Console.WriteLine("Task 1");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(EvenCount(array));

// Task 2
int OddIndexSum(int[] nums)
{
    int sm = 0;
    for (int i = 1; i < nums.Length; i += 2)
    {
        sm += nums[i];
    }
    return sm;
}

int[] arr = RandomIntegers(min: -50, max: 50);
Console.WriteLine("Task 2");
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(OddIndexSum(arr));

// Task 3
double[] RandomDoubles(int min, int max, int size = 8)
{
    double[] array = new double[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(r.Next(min, max)) + r.NextDouble();
    }
    return array;
}

double MinMaxDiff(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    foreach (double item in array)
    {
        if (item < minValue) minValue = item;
        if (item > maxValue) maxValue = item;
    }
    return maxValue - minValue;
}

double[] numbers = RandomDoubles(min: -10, max: 10);
Console.WriteLine("Task 3");
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(MinMaxDiff(numbers));