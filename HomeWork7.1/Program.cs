// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать 
// рекурсию, не использовать циклы.

Console.WriteLine("Ведите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(m, n);
PrintNaturalNumbers2(m, n);

void PrintNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    Console.Write($"{m} ");
    PrintNaturalNumbers(m + 1, n);
}

void PrintNaturalNumbers2(int m, int n)
{
    if (m < n)
    {
        return;
    }
    Console.Write($"{m} ");
    PrintNaturalNumbers2(m - 1, n);
}