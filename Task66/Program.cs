// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int numN, int numM)
{
    if(numN == numM) return numN;
    else if (numM > numN)
    {
        return numM + SumNumbers(numM - 1, numN);
    }
    else return numN + SumNumbers(numM, numN - 1);
   
}

Console.WriteLine("Введите N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {numM}; N = {numN} -> {SumNumbers(numN, numM)}");