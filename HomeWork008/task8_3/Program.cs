// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] matrixA = GetArray(rows, columns, minValue, maxValue);     // получаем matrixA через метод
PrintArray(matrixA);
Console.WriteLine();
int[,] matrixB = GetArray(rows, columns, minValue, maxValue);     // получаем matrixB через метод
PrintArray(matrixB);
Console.WriteLine();
PrintArray(MultiplyMatrix(matrixA, matrixB));                     // умножаем matrixA*matrixB 
 

// METHODS
// получаем двумерный массив заполненный случайными числами
int[,] GetArray(int m, int n, int minValue, int maxValue)     
{
    int[,] result = new int[m,n];
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);   
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

 // Умножение матрицы А на матрицу Б
int[,] MultiplyMatrix(int[,] A, int[,] B)
{
    int rA = A.GetLength(0);
    int cA = A.GetLength(1);
    int rB = B.GetLength(0);
    int cB = B.GetLength(1);
    int[,] matrixC = new int[rA, cB];
    if (cA != rB)                         // если кол-во строк и столбцов не равно умножить не можем
    {
        Console.WriteLine("Умножение матриц невозможно!");
    }
    else
    {
        int temp = 0;
        for (int i = 0; i < rA; i++)
        {
            for (int j = 0; j < cB; j++)
            {
                temp = 0;
                for (int k = 0; k < cA; k++)
                {
                    temp += A[i, k] * B[k, j];
                }
                matrixC[i, j] = temp;
            }
        }
        return matrixC;
    }
    return matrixC;
}

