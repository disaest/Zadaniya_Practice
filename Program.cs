using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "employee.txt";
            string logPath = "log.txt";
            string resultPath = "result.txt";

            DataReader dataReader = new DataReader();
            List<Employee> employees = dataReader.ReadEmployees(inputPath, logPath);

            if (employees.Count == 0)
            {
                File.WriteAllText(resultPath, "Нет данных для анализа.");
                Console.WriteLine("Нет данных для анализа.");
                return;
            }

            double averageSalary = employees.Average(employee => employee.Salary);
            Employee oldestEmployee = employees.OrderByDescending(employee => employee.Age).First();

            string result =
                $"Количество сотрудников: {employees.Count}{Environment.NewLine}" +
                $"Средняя зарплата: {averageSalary:F2}{Environment.NewLine}" +
                $"Самый старший сотрудник: {oldestEmployee.Name}, возраст: {oldestEmployee.Age}";

            File.WriteAllText(resultPath, result);
            Console.WriteLine(result);
        }
    }
}
