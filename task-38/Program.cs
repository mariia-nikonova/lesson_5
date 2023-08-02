Console.Write("Введите количесво элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
Random rand = new Random();
Console.Write("[ ");
int[] myArray(int s)      //заполнение массива случайными числами
{
    int[] array = new int[s];
    for (int i = 0; i < s; i++)
    {
        array[i] = rand.Next(1, 99);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int maxfunction (int[] myArray) //нахождение максимального элемента массива
{
    int max = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        if (max < myArray[i]) max = myArray[i];
    }
    return max;
}

int minfunction (int[] myArray) //нахождение минимального элемента массива
{
    int min = myArray[0];
    for (int i = 1; i < myArray.Length; i++)
    {
        if (min > myArray[i]) min = myArray[i];
    }
    return min;
}

int[] myArr = myArray(size);
Console.WriteLine("]");
int max = maxfunction(myArr);
Console.WriteLine($"Максимальное значение элемента массива: {max}");
int min = minfunction(myArr);
Console.WriteLine($"Минимальное значение элемента массива: {min}");
int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");
