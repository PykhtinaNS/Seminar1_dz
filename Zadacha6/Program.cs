// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int rez;
rez = number1 % 2;
if (rez == 0)
{
    Console.WriteLine("Да, число является четным");
}
else
{
    Console.WriteLine("Нет, число не является четным");
}
