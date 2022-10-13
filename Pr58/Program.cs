// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] A = new int[2, 2];
int[,] B = new int[2, 2];
int[,] C = new int[2, 2];
  for (int i = 0; i < A.GetLength(0) ; i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            A[i, j] = new Random().Next(1, 5);
            B[i, j] = new Random().Next(1, 5);
        }
    }
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            Console.Write($"{A[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            Console.Write($"{B[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
    for (int i = 0; i < A.GetLength(0); i++)
    {
      for (int j = 0; j < B.GetLength(1); j++)
      {
        C[i, j] = 0;
        for (int k = 0; k < A.GetLength(1); k++)
        {
            C[i, j] += A[i, k] * B[k, j];
        }
      }
    }
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            Console.Write($"{C[i, j]} ");
        }
         Console.WriteLine();
    }
 Console.WriteLine();
