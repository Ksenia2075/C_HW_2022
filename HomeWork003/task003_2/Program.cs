// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 > 0)
{
    Console.WriteLine($"третья цифра {num % 10}");
}
else
{
    Console.WriteLine("третей цифры нет");
}
