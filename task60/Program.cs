// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.WriteLine("Зададим трехмерный масив размером 2 x 2 x 2 ");
Console.WriteLine("Заполним  масив неповторяющимися двузначными числами \n");

int[,,] array = new int[2, 2, 2];

int[] numRandom = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(0)];
for (int i = 0; i < numRandom.GetLength(0); i++)
{
    int y = 0;
    numRandom[i] = new Random().Next(10, 100);
    y = numRandom[i];
    for (int j = 0; j < i; j++)
    {
        while (numRandom[i] == numRandom[j])
        {
            numRandom[i] = new Random().Next(10, 100);
            j = 0;
            y = numRandom[i];
        }
        y = numRandom[i];
    }
}

int n=0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int m = 0; m < 1; m++)
            {
                array[i, j, k] = numRandom[n];
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                n++;
            }
        }
    }
}

Console.WriteLine("\n");

/// Позже попробую переписать с применением методов