int Input()
{
    Console.WriteLine("Введите трехзначное число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}


int a = Input();
while (a < 100 || a >= 1000) 
{
    Console.WriteLine("Это не трехзначное число");
    a = Input();
}
int result = a / 10 % 10; 
Console.WriteLine($"Вторая цифра числа: {result}");

        