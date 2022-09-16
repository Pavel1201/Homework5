int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;

}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Массив чисел: ");
    foreach (int number in array)
    {

        Console.Write($"{number} ");
    }
}

int[] numbers = FillArray(5);
int sum = FindSum(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"{sum} ");