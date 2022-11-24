// 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

void FillArray(int[] arr)
{
    int length = arr.Length;
    for(int i = 0; i<length; i++)
    {
        arr[i] = new Random().Next(8);
    }
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i<length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
