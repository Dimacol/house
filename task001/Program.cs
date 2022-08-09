Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA < numberB) 
{
    Console.WriteLine("max = " + numberB); 
}
else if (numberB < numberA) 
{ Console.WriteLine("max = " + numberA); 
}
