//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
{
    Console.Write("Максимально число ");
    Console.WriteLine(numberA);
    Console.Write("Минимальное число ");
    Console.Write(numberB);
}

if(numberA < numberB)
{
    Console.Write("Максимально число ");
    Console.WriteLine(numberB);
    Console.Write("Минимальное число ");
    Console.Write(numberA);
}

if(numberA == numberB)
{
    Console.WriteLine("Введеные вами числа равны");
}


