// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));// формула нахождения расстояния
    return d;
}
Console.WriteLine("Введите координаты A:");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты B:");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
double D = distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние AB=" + Math.Round(D, 2));// округление 2 знака
