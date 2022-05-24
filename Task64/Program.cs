// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int n, int m)
{
    if (m == n)
    {
        return;
    }
    if (n < m)
    {
        Console.Write(m + " ");
        PrintNumbers(n, m - 1);
    }
    if (n > m)
    {
        Console.Write(m + " ");
        PrintNumbers(n, m + 1);
    }
}
PrintNumbers(n, m);
if (n<m)
{
    Console.Write(n + " ");
}
else
Console.Write(n + " ");