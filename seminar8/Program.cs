// Task 54
void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GenerateRandomMatrix(int min, int max, int m, int n)
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

void SortRows(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < mtrx.GetLength(1) - j - 1; k++)
            {
                if (mtrx[i, k] < mtrx[i, k + 1])
                {
                    int tmp = mtrx[i, k];
                    mtrx[i, k] = mtrx[i, k + 1];
                    mtrx[i, k + 1] = tmp;
                }
            }
        }
    }
}

int[,] randMatr = GenerateRandomMatrix(min: 0, max: 9, m: 6, n: 6);
Console.WriteLine("Task 54.\nRandom matrix:");
PrintMatrix(randMatr);
SortRows(randMatr);
Console.WriteLine("Sorted rows:");
PrintMatrix(randMatr);

// Task 56
int[] SumsOfRows(int[,] mtrx)
{
    int m = mtrx.GetLength(0);
    int n = mtrx.GetLength(1);
    int[] sums = new int[m];
    for (int i = 0; i < m; i++)
    {
        int sm = 0;
        for (int j = 0; j < n; j++)
        {
            sm += mtrx[i, j];
        }
        sums[i] = sm;
    }
    return sums;
}

int FindMin(int[] array)
{
    int MinValIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[MinValIndex]) MinValIndex = i;
    }
    return MinValIndex;
}

int[,] rectangularMatrix = GenerateRandomMatrix(min: 1, max: 9, m: 6, n: 4);
Console.WriteLine("Task 56.\nMatrix:");
PrintMatrix(rectangularMatrix);
Console.WriteLine($"Min sum of elements is in row {FindMin(SumsOfRows(rectangularMatrix)) + 1}.\n");

// Task 58
int[,] MultiplyMatrices(int[,] mtrxA, int[,] mtrxB)
{
    int m = mtrxA.GetLength(0);
    int n = mtrxB.GetLength(1);
    int[,] result = new int[m, m];
    if (m != n)
    {
        Console.WriteLine("It is impossible to multiply these matrices.");
        return result;
    }
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < m; l++)
            {
                result[i, j] += mtrxA[i, l] * mtrxB[l, j];
            }
        }
    }
    return result;
}

int[,] matrixA = GenerateRandomMatrix(min: 0, max: 9, m: 4, n: 4);
int[,] matrixB = GenerateRandomMatrix(min: 1, max: 9, m: 4, n: 4);
Console.WriteLine("Task 58.\nMatrix A:");
PrintMatrix(matrixA);
Console.WriteLine("Matrix B:");
PrintMatrix(matrixB);
Console.WriteLine("Product:");
PrintMatrix(MultiplyMatrices(matrixA, matrixB));

// Task 60
List<int> UniqueRandomNumbers(int min, int max, int size)
{
    List<int> nums = Enumerable.Range(min, max - min + 1).ToList();
    List<int> result = new List<int>();
    Random r = new Random();
    for (int i = 0; i < nums.Count; i++)
    {
        int randEl = r.Next(0, nums.Count);
        result.Add(nums[randEl]);
        nums.Remove(nums[randEl]);
    }
    return result.GetRange(0, size);
}

int[,,] Create3dArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    List<int> nums = UniqueRandomNumbers(10, 99, m * n * k);
    int c = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                array[i, j, l] = nums[c];
                c++;
            }
        }
    }
    return array;
}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.WriteLine($"{array[i, j, l]}({i},{j},{l})");
            }
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Task 60.");
Print3dArray(Create3dArray(2, 2, 2));

// Task 62
int[,] SpiralMatrix(int m, int n)
{
    int[,] mtrx = new int[m, n];
    int top = 0;
    int bottom = m - 1;
    int left = 0;
    int right = n - 1;
    int c = 1;
    while (c <= m * n)
    {
        for (int i = left; i < right + 1; i++)
        {
            mtrx[top, i] = c;
            c++;
        }
        top++;
        for (int i = top; i < bottom + 1; i++)
        {
            mtrx[i, right] = c;
            c++;
        }
        right--;
        for (int i = right; i > left - 1; i--)
        {
            mtrx[bottom, i] = c;
            c++;
        }
        bottom--;
        for (int i = bottom; i > top - 1; i--)
        {
            mtrx[i, left] = c;
            c++;
        }
        left++;
    }
    return mtrx;
}

Console.WriteLine("Task 62.\nSpiral matrix:");
PrintMatrix(SpiralMatrix(4, 4));