// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите число №1:");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.WriteLine("Введите число №2");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a > b)
{
    Console.WriteLine($"Число {a} больше");
}
else
{
    Console.WriteLine($"Число {b} больше");
}