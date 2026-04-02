using System;
using System.IO;
using System.Text.Json;
using Task1_22;

class Program
{
    static void Main()
    {
        string filePath = "model.json";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл model.json не найден.");
            return;
        }

        string jsonString = File.ReadAllText(filePath);

        Model? myObject = JsonSerializer.Deserialize<Model>(jsonString);

        if (myObject != null)
        {
            Console.WriteLine($"ID: {myObject.Id}");
            Console.WriteLine($"Name: {myObject.Name ?? "Данные отсутствуют"}");
            Console.WriteLine($"Description: {myObject.Description ?? "Данные отсутствуют"}");
            Console.WriteLine($"Created At: {myObject.CreatedAt?.ToString() ?? "Дата не указана"}");
        }
    }
}
