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

int honest(int[] myArray) //нахождение суммы элементов массива
{                         //с четными номерами
    int p = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (i % 2 == 0) p = p + myArray[i];
    }
    return p;
}

int[] myArr = myArray(size);
Console.WriteLine("]");
int quantity = honest(myArr);
Console.WriteLine($"Сумма элементов с четным индексом: {quantity}");
