// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNaturalNums(int m, int n)
{
    if (m > n) return 0;
    return m + SumOfNaturalNums(++m, n);
}

int m = ReadInt("Введите первое число: ");
int n = ReadInt("Введите второе число: ");

if (m < n)
{
    System.Console.WriteLine(SumOfNaturalNums(m, n));
}
else
{
    System.Console.WriteLine(SumOfNaturalNums(n, m));
}