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

int[,] MultiplicationArray(int[,] matrix1, int[,] matrix2, int[,] multiplicationMatrix)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))  // охранник
    {
        throw new Exception ("Нельзя умножать такие матрицы");
    }

    // int[,] multiplicationMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];  // 000000000

    for (int i = 0; i < multiplicationMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicationMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiplicationMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiplicationMatrix;
    
}

Console.WriteLine("Найти призведение двух матриц");

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] multiplicationMatrix = new int[2, 2];

FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine();
Console.WriteLine("Матица А");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матица В");
PrintArray(matrix2);
MultiplicationArray(matrix1, matrix2, multiplicationMatrix);
System.Console.WriteLine("\nПроизведение матриц А и В\n");
PrintArray(multiplicationMatrix);
