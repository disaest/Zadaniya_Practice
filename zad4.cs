using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (true)
        {
            Console.Write("Введите команду (добавить, найти, показать, выход): ");
            string command = (Console.ReadLine() ?? "").ToLower();

            if (command == "выход")
            {
                break;
            }
            else if (command == "добавить")
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Номер телефона: ");
                string phone = Console.ReadLine() ?? "";

                if (name.Length == 0)
                {
                    Console.WriteLine("Имя не должно быть пустым.");
                    continue;
                }

                contacts[name] = phone;
            }
            else if (command == "найти")
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine() ?? "";

                if (contacts.TryGetValue(name, out string phone))
                {
                    Console.WriteLine(phone);
                }
                else
                {
                    Console.WriteLine("Контакт не найден.");
                }
            }
            else if (command == "показать")
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }
            }
            else
            {
                Console.WriteLine("Неизвестная команда.");
            }
        }
    }
}
