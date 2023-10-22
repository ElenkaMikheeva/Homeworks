// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalcAckerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return CalcAckerman(m - 1, 1);
        }
        else
        {
            return CalcAckerman(m - 1, CalcAckerman(m, n - 1));
        }
    }

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = CalcAckerman(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
