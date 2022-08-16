//  Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 1е число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3е число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write("Max = ");
        Console.WriteLine(number1);
    }
}
else if (number2 > number3)
{
    Console.Write("Max = ");
    Console.WriteLine(number2);
}
else if (number2 < number3)
{
    Console.Write("Max = ");
    Console.WriteLine(number3);
}