// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
void Palindrom(string x)
{    
    if (x[0] == x[4] && x[1] == x[3])
        Console.WriteLine("Это полиндпром");
    else
    {
        Console.WriteLine("это не полидром");
    }
    return;
}
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length == 5)
{
    Palindrom(number);
}
else Console.WriteLine("попробуй еще раз");
