//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Input()
{
    Console.WriteLine("Введите число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}

int a = Input();
if (a < 100)
{
    Console.WriteLine("В данном числе отсутствует третья цифра");
    a = Input();
}

else
{
    int result = a;
    int b = 0;
    while (result > 99)
    {
        b = result % 10;
        result = result / 10;
    }

    Console.WriteLine($"В вашем числе третья цифра является {b}");
}
