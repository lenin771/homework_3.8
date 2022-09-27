// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Заполнение  массива спирально");

int[,] spiralMatrix = new int[4, 4];

int num = 1;
int i = 0;
int j = 0;

while (num <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = num;
  num++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      {
        Console.Write($" {array[i,j]} ");
      }
        else 
        {
            Console.Write($"{array[i,j]} ");
        }
    }
    Console.WriteLine();
  }
}

PrintArray(spiralMatrix);