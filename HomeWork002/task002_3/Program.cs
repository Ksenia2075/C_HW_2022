// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine("Диапазон координат x > 0, y < 0");
}
if (quarter == 2)
{
    Console.WriteLine("Диапазон координат x > 0, y > 0");
}
if (quarter == 3)
{
    Console.WriteLine("Диапазон координат x < 0, y < 0");
}
if (quarter == 4)
{
    Console.WriteLine("Диапазон координат x < 0, y > 0");
}
else
{
    Console.WriteLine("Вы ввели не корректное число");
}
