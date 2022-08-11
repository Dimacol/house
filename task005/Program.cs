Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());

// int a = number % 100;
// int b = a / 10;
// Console.WriteLine("Second number: " + b);

string strnumber = number.ToString();
Console.WriteLine("Второе число : " + strnumber[1]);