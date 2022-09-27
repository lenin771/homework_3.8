// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Найти призведение двух матриц");

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] sumMatrix = new int[2, 2];

FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine();
Console.WriteLine("Матица А");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матица В");
PrintArray(matrix2);

sumMatrix[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
sumMatrix[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
sumMatrix[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
sumMatrix[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];
Console.WriteLine("Произведение матриц АхВ");
PrintArray(sumMatrix);