// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine($"max {b}");
}
else
{
    Console.WriteLine($"min{a}");
}