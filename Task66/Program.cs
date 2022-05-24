// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int Sum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    sum = sum + m;
    Sum(m + 1, n);
    return sum;
}
if (m < n)
{
    sum = Sum(m, n) + n;
    Console.WriteLine($"Сумма чисел от {m} до {n} равна: {sum}");
}
else
{
    Console.WriteLine($"Вы ввели диапазон не правильно");
}
