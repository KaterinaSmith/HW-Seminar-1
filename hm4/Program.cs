﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int b = Convert.ToInt32(numberStr);

for (int i = 1; i <= b; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}