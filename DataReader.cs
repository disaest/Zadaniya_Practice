using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Practice4
{
    public class DataReader
    {
        public List<Employee> ReadEmployees(string filePath, string logPath)
        {
            List<Employee> employees = new List<Employee>();
            File.WriteAllText(logPath, "");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    string[] parts = line.Split(';');

                    if (parts.Length != 3)
                    {
                        File.AppendAllText(logPath,
                            $"Строка {lineNumber}: неверное количество данных.{Environment.NewLine}");
                        continue;
                    }

                    string name = parts[0].Trim();

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        File.AppendAllText(logPath,
                            $"Строка {lineNumber}: не указано имя сотрудника.{Environment.NewLine}");
                        continue;
                    }

                    if (!int.TryParse(parts[1].Trim(), NumberStyles.Integer,
                        CultureInfo.InvariantCulture, out int age))
                    {
                        File.AppendAllText(logPath,
                            $"Строка {lineNumber}: возраст должен быть числом.{Environment.NewLine}");
                        continue;
                    }

                    if (!int.TryParse(parts[2].Trim(), NumberStyles.Integer,
                        CultureInfo.InvariantCulture, out int salary))
                    {
                        File.AppendAllText(logPath,
                            $"Строка {lineNumber}: зарплата должна быть числом.{Environment.NewLine}");
                        continue;
                    }

                    employees.Add(new Employee(name, age, salary));
                }
            }

            return employees;
        }
    }
}
