// 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
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

int[] array = GetArray(10, 100, 1000);
PrintArray(array);

int count = 0;
for (int a = 0; a < array.Length; a++)
if (array[a] % 2 == 0)
count++;
Console.WriteLine();
Console.WriteLine($"четных чисел - {count}");

