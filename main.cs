

using System;

class Program
{
    static void bubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    // passed by Reference
                    swap(ref arr[j], ref arr[j + 1]);
                }
    }
    // using the keyword ref
    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] arr = { 54, 24, 15, 12, 32, 11, 90 };
        bubbleSort(arr);
        Console.WriteLine("Sorted array is: ");
        printArray(arr);
    }
}
