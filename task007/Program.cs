// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

string[] weekdays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("введите число недели: ");
int i = int.Parse(Console.ReadLine());
if (i < 6)
{
    Console.WriteLine($"не является выходным {weekdays[i-1]}");
}
else { Console.WriteLine($"Ура выходной погнали бухать!!! {weekdays[i-1]}"); }