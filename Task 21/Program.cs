// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты точки A:");
Console.Write("Введите X: ");
string ax = Console.ReadLine();
int x1 = int.Parse(ax);
Console.Write("Введите Y: ");
string ay = Console.ReadLine();
int y1 = int.Parse(ay);
Console.Write("Введите Z: ");
string az = Console.ReadLine();
int z1 = int.Parse(az);

Console.WriteLine("Введите координаты точки B:");
Console.Write("Введите X: ");
string bx = Console.ReadLine();
int x2 = int.Parse(bx);
Console.Write("Введите Y: ");
string by = Console.ReadLine();
int y2 = int.Parse(by);
Console.Write("Введите Z: ");
string bz = Console.ReadLine();
int z2 = int.Parse(bz);

int x = x2 - x1;

int y = y2 - y1;

int z = z2 - z1;

double R = Math.Sqrt (x * x + y * y + z * z);
double X = Math.Round (R, 2);
Console.WriteLine("Расстояние между точками = " + X);