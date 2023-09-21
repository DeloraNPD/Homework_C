// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int max = 0;
int min = 0;
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine($"Вы ввели одинаковые числа. Пожалуйста, перезапустите программу и повторите ввод еще раз.");
}
else
{
    if (num1 > num2)
    {
        max = num1;
        min = num2;
        Console.WriteLine($"Максимальное число - {max}, минимальное число - {min}");
    }
    else
    {
        max = num2;
        min = num1;
        Console.WriteLine($"Максимальное число - {max}, минимальное число - {min}");
    }
}