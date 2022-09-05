﻿// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void MultiplicationMtrx(int[,] array, int[,] array2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i, k] * array2[k, j];
            }
            result[i, j] = sum;
        }
    }
}

int[,] mtrxA = new int[2, 2];
int[,] mtrxB = new int[2, 2];
int[,] productMtrx = new int[2, 2];
FillArray(mtrxA);
FillArray(mtrxB);
PrintArray(mtrxA);
Console.WriteLine();
PrintArray(mtrxB);
MultiplicationMtrx(mtrxA, mtrxB, productMtrx);
Console.WriteLine("Результирующая матрица будет:");
PrintArray(productMtrx);