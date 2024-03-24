using System;

public class QuickSort
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        int[] array = new int[100];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 1000);
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        // Sortowanie tablicy
        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(array);
    }

    public static void QuickSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSortAlgorithm(array, left, pivotIndex - 1);
            QuickSortAlgorithm(array, pivotIndex + 1, right);
        }
    }

    public static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        Swap(array, i + 1, right);
        return i + 1;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}