int RangeMtoN(int m, int n)
{
    if (m == n) return n;
    else
        Console.Write($"{m}, ");
    return RangeMtoN(m + 1, n);
}

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) Console.WriteLine("Ошибка M<N!");
else
{
    int result = RangeMtoN(M, N);
   Console.Write($"{result} ");
}
