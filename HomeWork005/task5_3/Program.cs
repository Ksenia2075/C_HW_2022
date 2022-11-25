// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
Console.Clear();

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for(int i=0; i<size; i++)
    {
        res[i] = Convert.ToDouble(new Random().Next(minValue,maxValue+1)) / 100;
    }
    return res;
}

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

double[] array = GetArray(5,1,100);
PrintArray(array);
Console.WriteLine();

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < array.Length; a++)
{
    if (array[a] > max)
        {
            max = array[a];
        }
    if (array[a] < min)
        {
            min = array[a];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

