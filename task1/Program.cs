// Задача №1. Напишите программу проверки, является ли первое число квадратом второго
// a=25, b=5 -> да
// a=2, b=5 -> нет
Console.WriteLine("Введите первое число: ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("Является ли первое число квадратом второго?: ");
if (a==b*b) Console.WriteLine("Да");
else Console.WriteLine("Нет");
