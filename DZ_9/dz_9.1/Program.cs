
// Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1.


void Numbers(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
    else
    {
        m++;
        Console.Write($" {m} ");
        Numbers(m + 2, n);
    }
}
Console.WriteLine("Введите значение числа m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение числа n: ");
int n = int.Parse(Console.ReadLine());
Numbers(m, n);