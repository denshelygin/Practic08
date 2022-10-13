// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//           Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int [4,4];
int minSum = Int32.MaxValue;
int indexMinRow = 0;
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
    int Sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Sum = Sum + array[i, j];        
    }
    if (Sum < minSum)
    {
        minSum = Sum;
        indexMinRow = i;
    }
}
Console.Write($"{indexMinRow +1 } строка");
Console.WriteLine();
