using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[1];
        int count = 0;

        while (true)
        {
            Console.Write("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Введите целое число.");
                continue;
            }

            bool repeated = false;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] == number)
                {
                    repeated = true;
                    break;
                }
            }

            if (repeated)
            {
                break;
            }

            if (count == numbers.Length)
            {
                Array.Resize(ref numbers, numbers.Length * 2);
            }

            numbers[count] = number;
            count++;
        }

        Console.Write("Массив чисел: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
