 //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 Console.Clear();
 int Input()
{
    Console.WriteLine("Введи день недели");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}
    
 int day = Input();
 if (day == 1)
 {
    Console.WriteLine("понедельник - Работай, друг, солнце еще высоко.");
 }
 else if (day == 2)
 {
    Console.WriteLine("вторник, продолжай трудится, неделя только началась");
 }
 else if (day == 3)
 {
    Console.WriteLine("среда, лааадно, уже экватор.");
 }
 else if (day == 4)
 {
    Console.WriteLine("четверг, еще чуть чуть, бро");
 }
 else if (day == 5)
 {
    Console.WriteLine("пятница, вот оно, последний день настал!");
 }
 else if (day == 6)
 {
    Console.WriteLine("суббота, УРА, впереди тебя ждет еще один день выходного дня");
 }
 else if (day == 7)
 {
    Console.WriteLine("воскресенье, радуйся, но не сильно, завтра на работу");
 }

 else
 {
    Console.WriteLine("Такого дня недели нет, не забывай об этом.");
 }