// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

int[] array = GetArray(5, 1, 10);
PrintArray(array);
Console.WriteLine();

int sum = 0;
for (int a = 0; a < array.Length; a+=2)
    sum = sum + array[a];

    Console.WriteLine($"сумма нечетных чисел - {sum}");
