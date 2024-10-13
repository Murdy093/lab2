using System;

class Program
{
    static void Main()
    {

        int[] numbers = new int[10];

        Console.WriteLine("Введіть 10 цілих чисел:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Math.Abs(numbers[i]);
        }

        Console.WriteLine("Масив після заміни елементів на їх модулі:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nPress any key to complete...");
        Console.ReadKey();

    }
}
