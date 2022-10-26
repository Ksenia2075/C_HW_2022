// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number2 == number1 * number1)
{
    Console.WriteLine($"Число {number1} квадрат числа {number2}");
}
if (number1 == number2 * number2)
{
    Console.WriteLine($"Число {number2} квадрат числа {number1}");
}
if (number1 != number2 * number2 && number2 != number1 * number1)
{
    Console.WriteLine($"Число {number1} не квадрат числа {number2}");
    Console.WriteLine($"Число {number2} не квадрат числа {number1}");
}