// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2   В итоге получается вот такой массив:  7 4 2 1
// 5 9 2 3                                         9 5 3 2
// 8 4 2 4                                         8 4 4 2

int[,] array = new int [3,4];
   for ( int i = 0; i < array.GetLength(0); i++)
   {
       for (int  j = 0; j <array.GetLength(1); j++)
       {
        array[i,j] = new Random().Next(1,10);
        Console.Write($"{array[i,j]} ");
       }
       Console.WriteLine();
    }
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int x = 0; x < array.GetLength(1) - 1; x++)
        {
            if (array[i, x] < array[i, x + 1]) 
            {
                int count = 0;
                count = array[i, x];
                array[i, x] = array[i, x + 1];
                array[i, x + 1] = count; 
            }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
