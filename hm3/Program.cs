﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);

if (a % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число НЕ чётное");
}