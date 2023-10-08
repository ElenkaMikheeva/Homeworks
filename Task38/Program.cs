// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(size);
PrintArray(myArray);
Console.WriteLine($"{MaxElement(myArray):N2} - {MinElement(myArray):N2} = {(MaxElement(myArray) - MinElement(myArray)):N2}");

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-100, 100) + rand.NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:N2} ");
    }
    Console.Write("] ");
}

double MaxElement(double[] array)
{
    double max = array[0];
        for(int i=0; i < array.Length; i++)
    { 
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
        for(int i=0; i < array.Length; i++)
    { 
        if (array[i] < min) min = array[i];
    }
    return min;
}