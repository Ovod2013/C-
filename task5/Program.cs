// Задача №5 на входе одно число N, на выходе все целые числа в промежутке от -N до N
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int num = - number;
while (num <= number)
{
    Console.WriteLine(num + " ");

    num=num+1;
}
