// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
int ApowB(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");

int B = int.Parse(Console.ReadLine());
int power = ApowB(A, B);
Console.WriteLine("А в степени В: " + power);