// Задача 2: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Ведите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = FunctionAckerman(m, n);
Console.Write($"A({m}, {n}) = {result}");

int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (n == 0)
    {
        return FunctionAckerman(m - 1, 1);
    }
    return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}

