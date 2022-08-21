// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

int summ(int number)
{
    string num = Convert.ToString(number);
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        int temp = number % 10;
        sum += temp;
        number /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine());
if (A <= 0) { Console.WriteLine("Ошибка"); }
else Console.WriteLine("Сумма цифр в числе:" + summ(A));
