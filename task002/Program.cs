Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine("max =" + numberA);
} 
else if (numberB > numberC && numberB > numberA)
{
    Console.WriteLine("max =" + numberB);}
else if (numberC > numberA && numberC > numberB){Console.WriteLine("max =" + numberC);
}
else if (numberA == numberB || numberA == numberC)
{
    Console.WriteLine("max =" + numberA);
}
else if (numberB == numberC)
{
    Console.WriteLine("max = " + numberB);
}
