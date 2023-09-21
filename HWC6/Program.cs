// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int even_number = number % 2;

if (even_number == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}