// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

double FunAkkerman(double m, double n)
{
    if (m == 0)
        return n + 1;
    else
        if (m != 0 && n == 0)
        return FunAkkerman(m - 1, 1);
    else
        return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
}

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0) Console.WriteLine("Неправильный ввод");
else
{
    Console.WriteLine($"функция Аккермана A({m},{n}) = {FunAkkerman(m, n)}");
}