Console.Clear();
 int Input()
{
    Console.WriteLine("Введи день недели");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}
    
 int day = Input();
 if(day == 6 || day == 7)
 {
    Console.WriteLine("Выходной");
 }
 else if(day > 0 && day < 6)
 {
    Console.WriteLine("Работай");
 }
 else if(day > 7)
 {
    Console.WriteLine("такого дня нет");
 }