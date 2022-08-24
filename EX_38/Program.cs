using System;

class Program
{
    static void Main(string[] args)

    {
        Console.Write("Введите размерность массива: ");
        int size = int.Parse(Console.ReadLine());
        double[] arr = new double[size];
        Random rnd = new Random();
        Console.WriteLine("Массив:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 100);
            Console.Write(arr[i] + " ");

        }
        var min = arr[0];
        var max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else if (arr[i] > max)
            {
                max = arr[i];
            }

        }
        Console.WriteLine("\nМинимальный элемент: " + min);
        Console.WriteLine("Максимальный элемент: " + max);

        double dif = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            dif = max - min;
        }

        Console.WriteLine("Разность: " + dif);


    }
}