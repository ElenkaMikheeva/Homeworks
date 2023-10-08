// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size);
PrintArray(myArray);
Console.WriteLine(SumOddPozition(myArray));

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] ");
}

int SumOddPozition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i ++) 
    {
        if ( i % 2 != 0 )
        {
            sum += array[i];
        }
    }
    return sum;
}
