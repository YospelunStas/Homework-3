// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (т.е. число должно быть одинаковым при чтении слева направо и справа налево).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите пятизначное число: ");
string number = Console.ReadLine();
for (int i = 0; i < number.Length - i; i++)
{
    if (number[i] == number[number.Length - 1 - i])
    {
        Console.WriteLine($"{number} - палиндром.");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром.");
    }
    break;
}