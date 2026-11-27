using System;
using System.Collections.Generic;
using System.IO;

namespace EquipmentDemo
{
    class Equipment
    {
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> registrationQueue = new List<Equipment>
            {
                new Equipment { ModelName = "Сервер SRV-200", SerialNumber = "SN-99482" },
                new Equipment { ModelName = "Коммутатор SW-10", SerialNumber = "" },
                new Equipment { ModelName = "Маршрутизатор RT-5", SerialNumber = "SN-11023" }
            };

            Console.WriteLine("Запуск процедуры регистрации нового оборудования...");
            RegisterEquipmentBatch(registrationQueue);
            Console.WriteLine("Процедура регистрации завершена.");
        }

        static void RegisterEquipmentBatch(List<Equipment> items)
        {
            string logPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                "equipment_errors.log");

            foreach (Equipment item in items)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(item.SerialNumber))
                    {
                        throw new InvalidOperationException("Серийный номер не может быть пустым.");
                    }

                    RegisterInSystem(item);
                }
                catch (Exception ex)
                {
                    string logLine = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] | Модель: {item.ModelName} | Сбой: {ex.Message}";
                    File.AppendAllText(logPath, logLine + Environment.NewLine);
                    Console.WriteLine($"[ОШИБКА] {ex.Message}");
                }
            }
        }

        static void RegisterInSystem(Equipment eq)
        {
            Console.WriteLine($"[СИСТЕМА] Оборудование '{eq.ModelName}' (S/N: {eq.SerialNumber}) успешно внесено в реестр.");
        }
    }
}
