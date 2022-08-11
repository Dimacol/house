// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string strnumber  = number .ToString();
if (strnumber .Length > 2)
{
    Console.WriteLine("третья цифра: " + strnumber [2]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
