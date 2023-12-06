// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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

int FindElementAtPosition(int[,] matrix, int row, int col)
{
    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
    {
        return matrix[row, col];
    }

    // В случае ошибки возвращаем -1 или другое значение по умолчанию
    return -1;
}
// -----------------------------

int rows = ReadInt("Введите количество строк в матрице: ");

int cols = ReadInt("Введите количество столбцов в матрице: ");

int[,] matrix = GenerateMatrix(rows, cols, 5, 10);

PrintMatrix(matrix);

int stroka = ReadInt("Введите значение строки в матрице: ");
int stolb = ReadInt("Введите значение столбца: ");

int foundElement = FindElementAtPosition(matrix, stroka, stolb);

if (foundElement != -1)
{
    Console.WriteLine($"Элемент в позиции ({stroka}, {stolb}): {foundElement}");
}
else
{
    Console.WriteLine($"Ошибка: элемент не найден на указанной позиции.");
}
