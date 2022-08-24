using System;

class Program
{
    static void Main(string[] args)

    {
        Console.Write("Введите размерность массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Random rnd = new Random();
        Console.WriteLine("Массив:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100, 999);
            Console.Write(arr[i] + " ");

        }
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) res++;
        }

        Console.WriteLine("\nКоличество четных чисел:" + res);
    }
}