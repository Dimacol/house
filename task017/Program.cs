// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел :");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
void NumbersBolZero(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {

        if (numbers[i] > 0)
        {
            count++;
        }

    }
    Console.WriteLine("Чисел больше 0: " + count);
}

NumbersBolZero(numbers);