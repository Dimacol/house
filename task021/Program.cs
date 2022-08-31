// Напишите программу, которая на вход принимает число, 
// и возвращает индексы этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
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

void FindNumber(int[,] array, int find)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find)
            {
                Console.WriteLine($"Элемент равен {find}: [{i} , {j}], ");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine($"Такого числа в массиве нет!");
}

Console.WriteLine("Введите размер массива");
Console.Write("Введите число строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
FillArray(array);
PrintArray(array);
Console.Write("Введите число: ");
int find = int.Parse(Console.ReadLine());
FindNumber(array, find);

