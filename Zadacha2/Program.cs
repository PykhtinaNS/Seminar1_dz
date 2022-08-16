// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите 1е число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("Max = ");
    Console.WriteLine(number1);
    Console.Write("Min = ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(number2);
    Console.Write("Min = ");
    Console.WriteLine(number1);
}