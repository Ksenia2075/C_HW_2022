// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] array = {1, 2, 3, 4, 5, 6, 7};
if ( number > array[4])
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}
