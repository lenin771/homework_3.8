// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void SumMatrixRows(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[i] = arr[i] + array[i, j];
        }

    }
    int min = int.MaxValue; int m = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            m = i + 1;
        }
    }
    Console.Write($"Наименьшая сумма элементов в строке {m} = {min} \n");
    Console.WriteLine();
}

Console.WriteLine("Работа с двумерным масивом");
int height = EnterInt("Введите число строк: ");
int width = EnterInt("Введите число столбцов: ");
int[,] array = new int[height, width];

FillArray(array);
Console.WriteLine();
PrintArray(array);
SumMatrixRows(array);


