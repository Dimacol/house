// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SummRow(int[,] array, int index)
{
int summLine = array[index, 0];
for (int j = 1; j < array.GetLength(0); j++)
{
summLine += array[index, j];
}
return summLine;
}

void RowMinSummElements(int[,] array)
{
    int minLineIndex = 0;
    int summLine = SummRow(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = SummRow(array, i);
        if (summLine > temp)
        {
            summLine = temp;
            minLineIndex = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой: {minLineIndex + 1} строка");
}



Console.WriteLine("Введите размер массива");
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
FillArray(array);
PrintArray(array);
RowMinSummElements(array);