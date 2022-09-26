// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortingHeightArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxElement = 0;
            for (int k = j + 1; k < array.GetLength(0); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    maxElement = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = maxElement;
                }
            }

        }
    }
}


Console.WriteLine("Работа с двумерным масивом");
int height = EnterInt("Введите число строк: ");
int width = EnterInt("Введите число столбцов: ");
int[,] array = new int[height, width];
FillArray(array);
Console.WriteLine();
PrintArray(array);
SortingHeightArray(array);
Console.WriteLine();
PrintArray(array);


