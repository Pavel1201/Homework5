double[] FillArray(int size)
{
    double[] array = new double[size];
    Console.WriteLine("Введите массив вещественных чисел: ");

    for (int i = 0; i < size; i++)
    {
        array[i] = double.Parse(Console.ReadLine()!);
    }
    return array;

}

double FindDifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = max - min;
    return diff;
}

void PrintArray(double[] array)
{
    Console.WriteLine("Массив чисел: ");
    foreach (double number in array)
    {

        Console.Write($"{number} ");
    }
}


double[] numbers = FillArray(5);
double difference = FindDifferenceMinMax(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"{difference} ");





