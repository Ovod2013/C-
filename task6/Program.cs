// программа показывает последнюю цифру введённого трёхзначного числа


Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
if(number>99 && number<1000)
{
    Console.Write("Последняя цифра числа " + number%10);
}
else Console.Write("Это не трёхзначное число");
