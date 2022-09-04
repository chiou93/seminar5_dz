// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



class Program
{
    static int MaxNumberArray(int[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    static int MinNumberArray(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 56, 678, 124, 3 };
        int max = MaxNumberArray(array);
        int min = MinNumberArray(array);
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(max - min);
    }
}