// 25.Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Clear();

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int num = Degree(A, B);

int Degree(int A, int B)
{
    int num = A;
    for (int i=1; i>B; i++)
    {
        num = num *A;
    }
    return num;
}
Console.Write(num);