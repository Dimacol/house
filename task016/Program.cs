// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

double[] FillArray(double[] array, int min = 0, int max = 100)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 10;
        Console.Write("{0,6:F3}", array[i], ", ");
    }
    Console.WriteLine();
    return array;
}

double DifMinMax(double[] array)
{
    double min = array[0], max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double dif = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементов массива " + "{0,6:F3}", dif);
    return dif;
}

double[] array = new double[10];
DifMinMax(FillArray(array));
