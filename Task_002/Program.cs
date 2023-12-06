// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

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

void SwapFirstAndLastRow(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    if (rows >= 2)
    {
        int[] tempRow = new int[cols];

        for (int j = 0; j < cols; j++)
        {
            tempRow[j] = matrix[0, j];
        }

        for (int j = 0; j < cols; j++)
        {
            matrix[0, j] = matrix[rows - 1, j];
        }

        for (int j = 0; j < cols; j++)
        {
            matrix[rows - 1, j] = tempRow[j];
        }
    }
}
// -----------------------------

int rows = ReadInt("Введите количество строк в матрице: ");

int cols = ReadInt("Введите количество столбцов в матрице: ");

int[,] matrix = GenerateMatrix(rows, cols, 5, 10);

PrintMatrix(matrix);

SwapFirstAndLastRow(matrix);

Console.WriteLine("\nМатрица после замены первой и последней строки:");

PrintMatrix(matrix);