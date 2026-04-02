using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string filePath = "list.json";

        if (!File.Exists(filePath)) return;

        string jsonString = File.ReadAllText(filePath);

        using (JsonDocument doc = JsonDocument.Parse(jsonString))
        {
            if (doc.RootElement.ValueKind == JsonValueKind.Array)
            {
                Console.WriteLine("Коллекция объектов:");

                foreach (JsonElement element in doc.RootElement.EnumerateArray())
                {
                    Console.WriteLine("Объект -");

                    foreach (JsonProperty property in element.EnumerateObject())
                    {
                        if (property.Value.ValueKind != JsonValueKind.Null)
                        {
                            Console.WriteLine($"{property.Name}: {property.Value}");
                        }
                    }
                }
            }
        }
    }
}
