// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
void ShowNumbers(int num1)
{
    if (num1 >= 1)
    {
        System.Console.Write($" {num1}, ");
        ShowNumbers(num1 - 1);
    }
}
Console.WriteLine("Введите N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num1} -> ");
ShowNumbers(num1);





