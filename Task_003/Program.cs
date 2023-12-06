// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
int[,] tempMatrix = new int[row, col];
Random rand = new Random();

for (int i = 0; i < tempMatrix.GetLength(0); i++)
{
for (int j = 0; j < tempMatrix.GetLength(1); j++)
{
tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
}
}
return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
for (int i = 0; i < matrixForPrint.GetLength(0); i++)
{
for (int j = 0; j < matrixForPrint.GetLength(1); j++)
{
System.Console.Write(matrixForPrint[i, j] + "\t");
}
System.Console.WriteLine();
}
}

int FindRowWithMinSum(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    if (rows == 0 || cols == 0)
    {
        Console.WriteLine("Матрица пуста.");
        return -1;
    }

    int minSum = int.MaxValue;
    int minSumRow = -1;

    for (int i = 0; i < rows; i++)
    {
        int currentSum = 0;

        for (int j = 0; j < cols; j++)
        {
            currentSum += matrix[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRow = i;
        }
    }
    return minSumRow;
}
// -----------------------------

int rows = ReadInt("Введите количество строк в матрице: ");

int cols = ReadInt("Введите количество столбцов в матрице: ");

int[,] matrix = GenerateMatrix(rows, cols, 5, 10);

PrintMatrix(matrix);

int rowWithMinSum = FindRowWithMinSum(matrix);

if (rowWithMinSum != -1)
{
    Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {rowWithMinSum + 1}");
}