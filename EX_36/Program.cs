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
            arr[i] = rnd.Next(0, 100);
            Console.Write(arr[i] + " ");

        }
        int sum = 0;
       for (int i = 1; i < arr.Length; i+=2)

            {

                  sum += arr[i];
                  
            }
            Console.WriteLine("\nСумма:" + sum);
    }
}