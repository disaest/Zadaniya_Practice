using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива N: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Размер массива должен быть положительным числом.");
            return;
        }

        int[] numbers = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Введите целое число: ");
            }
            sum += numbers[i];
        }

        double average = (double)sum / n;

        Console.Write("Массив в обратном порядке: ");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }

        int closest = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(numbers[i] - average) < Math.Abs(closest - average))
            {
                closest = numbers[i];
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Среднее арифметическое: {average}");
        Console.WriteLine($"Ближайшее к среднему число: {closest}");
    }
}
