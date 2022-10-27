// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine("Растояние между точками: ");
Console.WriteLine(distance);