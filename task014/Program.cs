// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int[] array, int min = 100, int max = 1000)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}
int EvenNimbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) { count++; }
    }
    Console.WriteLine(" Количество чётных чисел в массиве: " + count);
    return count;
}
int[] array = new int[10];
FillArray(array);
EvenNimbers(array);