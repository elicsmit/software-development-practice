using System;
using System.IO;
using System.Text.Json.Nodes;

class Program
{
    static void Main()
    {
        string filePath = "service.json";

        if (!File.Exists(filePath)) return;

        string jsonString = File.ReadAllText(filePath);

        JsonArray rootArray = JsonNode.Parse(jsonString).AsArray();

        double minVal = double.MaxValue;

        foreach (var node in rootArray)
        {
            double current = (double)node["Price"];
            if (current < minVal)
            {
                minVal = current;
            }
        }

        for (int i = rootArray.Count - 1; i >= 0; i--)
        {
            if ((double)rootArray[i]["Price"] == minVal)
            {
                rootArray.RemoveAt(i);
            }
        }

        Console.WriteLine("Данные после удаления объектов с минимальной ценой:");
        Console.WriteLine(rootArray.ToString());
    }
}
