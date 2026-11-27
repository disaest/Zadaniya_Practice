using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество студентов: ");
        if (!int.TryParse(Console.ReadLine(), out int students) || students <= 0)
        {
            Console.WriteLine("Количество должно быть положительным числом.");
            return;
        }

        Console.Write("Введите количество предметов: ");
        if (!int.TryParse(Console.ReadLine(), out int subjects) || subjects <= 0)
        {
            Console.WriteLine("Количество должно быть положительным числом.");
            return;
        }

        int[,] marks = new int[students, subjects];

        for (int i = 0; i < students; i++)
        {
            int sum = 0;
            for (int j = 0; j < subjects; j++)
            {
                Console.Write($"Оценка студента {i + 1} по предмету {j + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out marks[i, j]))
                {
                    Console.Write("Введите целое число: ");
                }
                sum += marks[i, j];
            }

            double average = (double)sum / subjects;
            Console.WriteLine($"Средняя оценка студента {i + 1}: {average}");
        }
    }
}
