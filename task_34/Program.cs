Console.Write("Введите количесво элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
Random rand = new Random();
Console.Write("[ ");
int[] myArray(int s)      //заполнение массива случайными числами
{
    int[] array = new int[s];
    for (int i = 0; i < s; i++)
    {
        array[i] = rand.Next(100, 999);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int honest(int[] myArray) //нахождение количества четных чисел в заданном массиве
{
    int p = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0) p = p + 1;
    }
    return p;
}

int[] myArr = myArray(size);
Console.WriteLine("]");
int quantity = honest(myArr);
Console.WriteLine($"Количесво четных чисел в данном массиве: {quantity}");
