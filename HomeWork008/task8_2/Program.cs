﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, minValue, maxValue);     // получаем массив через метод
PrintArray(array);
Console.WriteLine();
RowMinSumElements(array);

// METHODS
int[,] GetArray(int m, int n, int minValue, int maxValue)     // метод. получаем двумерный массив
{
    int[,] result = new int[m,n];
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);   // заполненный случайными числами
        }
    }
    return result;
}


void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void RowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"минимальная сумма элементов в строке номер {minSumRow + 1}");
}


