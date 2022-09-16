
int[] FillArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;

}

int FindNumberOfEvenNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
Console.WriteLine("Массив чисел: ");
foreach( int number in array)
{
    
    Console.Write($"{number} ");
}
}

int[] numbers = FillArray(5);
int numberOfEvenNumbers = FindNumberOfEvenNumbers(numbers);
PrintArray(numbers);
Console.WriteLine($"Количество четных: {numberOfEvenNumbers}");