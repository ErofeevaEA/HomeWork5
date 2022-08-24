using System;

class Program
{
    static void Main(string[] args)

    {
        int[] arr = new int[123];
        int i = 0;
        Random rand = new Random();

        for (i = 0; i < 123; i++)
        {
            arr[i] = new Random().Next(0, 123);

            Console.Write(arr[i] + "  ");
        }
        int count = 0;

        for (i = 0; i < 123; i++)
        {
            if ((arr[i] >= 10) && (arr[i] <= 99)) count++;
        }

        Console.WriteLine("\nКоличество элементов в диапазоне: " + count);
        Console.Write(" ");
    }
}