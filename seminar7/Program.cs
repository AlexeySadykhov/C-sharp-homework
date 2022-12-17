// Task 1
void PrintDoubleMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] RandomDoubleMatrix(int m, int n)
{
    double[,] mtrx = new double[m, n];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i, j] = Convert.ToDouble(r.Next(0, 10) + r.NextDouble());
        }
    }
    return mtrx;
}

double[,] randMatr = RandomDoubleMatrix(6, 6);
Console.WriteLine("Task 1.");
PrintDoubleMatrix(randMatr);

// Task 2
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

void CoordsValue(double[,] mtrx, int i, int j)
{
    if (i >= mtrx.GetLength(0) || j >= mtrx.GetLength(1) || i < 0 || j < 0)
    {
        Console.WriteLine("No such element in array.");
    }
    else Console.WriteLine(mtrx[i, j]);
}

Console.WriteLine("Task 2.");
int[] coords = GetArray("Enter coordinates of the matrix (i, j) splitting values by space:");
CoordsValue(randMatr, coords[0], coords[1]);

// Task 3
void PrintIntMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] RandomIntMatrix(int min, int max, int m, int n)
{
    int[,] mtrx = new int[m, n];
    Random r = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mtrx[i, j] = r.Next(min, max + 1);
        }
    }
    return mtrx;
}

double[] FindAvgOfColumn(int[,] mtrx)
{
    int rowSize = mtrx.GetLength(1);
    int colSize = mtrx.GetLength(0);
    double[] avg = new double[rowSize];
    for (int j = 0; j < rowSize; j++)
    {
        int sm = 0;
        for (int i = 0; i < colSize; i++)
        {
            sm += mtrx[i, j];
        }
        avg[j] = Convert.ToDouble(sm) / Convert.ToDouble(colSize);
    }
    return avg;
}

Console.WriteLine("Task 3.\nMatrix:");
int[,] randIntMatr = RandomIntMatrix(min: 1, max: 10, m: 4, n: 6);
PrintIntMatrix(randIntMatr);
var result = string.Join(" ", FindAvgOfColumn(randIntMatr));
Console.WriteLine($"Avg's of each column are:\n{result}");