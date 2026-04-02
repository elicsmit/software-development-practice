using System;
using System.IO;
using Newtonsoft.Json;
using Task2_23;

class Program
{
    static void Main()
    {
        string filePath = "data.json";

        Zoo myZoo = new Zoo();
        myZoo.Animals.Add(new Animal { Name = "Барсик", Species = "Кот", Age = 3, SecretNotes = "Боится пылесоса" });
        myZoo.Animals.Add(new Animal { Name = "Рекс", Species = "Пес", Age = 5, SecretNotes = "Любит тапки" });

        string jsonOutput = JsonConvert.SerializeObject(myZoo, Formatting.Indented);
        File.WriteAllText(filePath, jsonOutput);

        Console.WriteLine("Данные успешно сохранены в data.json");

        string jsonInput = File.ReadAllText(filePath);
        Zoo loadedZoo = JsonConvert.DeserializeObject<Zoo>(jsonInput);

        Console.WriteLine("\nРезультат десериализации:");
        if (loadedZoo != null)
        {
            foreach (var animal in loadedZoo.Animals)
            {
                Console.WriteLine($"Животное: {animal.Species}, Кличка: {animal.Name}, Возраст: {animal.Age}");
            }
        }
    }
}
