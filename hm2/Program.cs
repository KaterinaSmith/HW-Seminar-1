//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
 
Console.WriteLine("Введите число №1:");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.WriteLine("Введите число №1:");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

Console.WriteLine("Введите число №1:");
string number3 = Console.ReadLine();
int c = Convert.ToInt32(number3);

int max = Math.Max(a, Math.Max(b, c));
Console.WriteLine($"Число {max} больше");