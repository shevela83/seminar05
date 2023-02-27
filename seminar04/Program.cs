// задайте одномерныймассив из 123 случайных чисел.
// найдите количество элементов массива, значения которых лежат в отрезке от [10, 99]
Console.Clear();
int[] starArray = GetArray(123, 0, 1000);
Console.WriteLine($"Количество элементов в отрезке [10;99] = {GetCountElements(starArray, 10, 99)}");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item >= leftRange && item <= rigthRange) count++;
    }
    return count;
}