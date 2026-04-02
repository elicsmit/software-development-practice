using System.Net.Cache;
using Task2;
public class Program
{
    public static void Main(string[] args)
    {
        var list = new List<Person>
        {
            new Person{Name = "Angelina", Age = 17, CreatedAt = DateTime.Now, MiddleName = "Пипипипи", Score = 10 },
            new Person{Name = "Tom", Age = 24, CreatedAt = DateTime.Now, MiddleName = null, Score = null },
        };

        string json = "\n";

        foreach (var p in list)
        {
            json += "[\n";
            json += $"[ Name - {p.Name}],\n"; 
            json += $"[ Age - {p.Age}],\n";
            json += $"[ CreatedAt - {p.CreatedAt}],\n";
            json += $"[ MiddleName - {p.MiddleName}],\n";
            json += $"[ Score - {p.Score}]\n";
            json += "\n]";

        }

        File.WriteAllText("list.json", json);
        Console.WriteLine("Данные записаны в файл list.json");
    }
}