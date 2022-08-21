//Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

void FillArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);