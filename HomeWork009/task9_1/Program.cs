// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 2;
EvenNumToLow(number, count);

void EvenNumToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        EvenNumToLow(n, count + 2);
        Console.Write(count + " ");
    }
}

