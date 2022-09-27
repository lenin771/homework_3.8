// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.WriteLine("Зададим трехмерный масив размером 2 x 2 x 2 ");

int[,,] array = new int[2, 2, 2];
int m = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, j, k] = new Random().Next(10 + m, 20 + m);
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            m = m + 10;
        }

    }
}

