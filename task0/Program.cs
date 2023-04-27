// Написать программу, которая выдаёт квадрат вводимого числа
// Пример: 4 -> 16
Console.Write("Введите число: "); // Запрос числа
int number = int.Parse(Console.ReadLine() !);// Пользователь вводит число
// Console.WriteLine(number * number); // Первый вариант
int sdr = number * number;// Второй вариант, кладём результат сначала в переменную
Console.WriteLine("Квадрат числа = " + sdr);// Вывод результата
