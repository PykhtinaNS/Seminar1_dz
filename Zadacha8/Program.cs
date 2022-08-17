// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 1;
while (number2 <= number1)
{
     if (number2 % 2 == 0)     
     {
        Console.WriteLine(number2);
     }
        number2 = number2 + 1;
}
