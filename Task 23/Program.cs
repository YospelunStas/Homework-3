// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Cube (int x)
{
    int result = x * x * x;
    return result;
}

Console.Write("Введите положительное число: ");
string number = Console.ReadLine();
int X = int.Parse(number);
if (X >= 0)
{
    for (int i = 1; i <= (X); i++)
    {
        int num1 = Cube(i);
        Console.WriteLine(num1);
    }
}
else
{
    for (int i = -1; i >= (X); i--)
    {
        int num2 = Cube(i);
        Console.WriteLine(num2);
    }
}