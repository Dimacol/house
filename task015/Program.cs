// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int[] array, int min = -99, int max = 100)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

int SumOddNumbers(int [] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( i % 2 != 0)  {summ += array[i];} 
    }
    Console.WriteLine("сумма элементов, стоящих на нечётных позициях: " + summ);
    return summ;
}
int [] array = new int[10];
SumOddNumbers(FillArray(array)); 