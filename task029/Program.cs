// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummMtoN(int m, int n)
{
    int Summ = m;
    if (m == n) return n;
    else
        Summ = Summ + SummMtoN(m + 1, n);
    return Summ;
}

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());


if (M > N) Console.WriteLine("Ошибка M<N!");
else
{
    int result = SummMtoN(M, N);
    Console.WriteLine($"Сумма от {M} до {N} = {result}");
}