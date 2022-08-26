// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
double[,] koeff = new double[2, 2];
double[] dot = new double[2];
void FillArray()
{
    for (int i = 0; i < koeff.GetLength(0); i++)
    {
        for (int j = 0; j < koeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите k{i + 1}:");
            else Console.Write($"Введите b{i + 1}:");
            koeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] crossroad (double[,] function)
{
    dot[0] = (koeff[1, 1] - koeff[0, 1]) / (koeff[0, 0] - koeff[1, 0]);
    dot[1] = dot[0] * koeff[0, 0] + koeff[0, 1];
    return dot;
}

void Print(double[,] function)
{
    if (koeff[0, 0] == koeff[1, 0] && koeff[1, 1] == koeff[0, 1])
    {
        Console.WriteLine("Линии совпадают!");
    }
    else if (koeff[0, 0] == koeff[1, 0] && koeff[1, 1] != koeff[0, 1])
    {
        Console.WriteLine("Линии параллельны!");
    }
    else
    {
        crossroad(koeff);
        Console.Write($"Точка пересечения двух прямых:[{dot[0]},{dot[1]}]");
    }
}
FillArray();
Print(koeff);