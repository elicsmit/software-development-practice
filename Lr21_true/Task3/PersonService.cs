using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class PersonService
    {
        public void ProcessAndSave(List<Person> people)
        {
            var result = people

                .Where(p => p.MiddleName != null && p.Score != null && p.Age >= 18)
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Age)
                .ToList();

            SaveManualJson(result, "service.json");
        }

        private void SaveManualJson(List<Person> list, string fileName)
        {
            string json = "[\n";
            for (int i = 0; i < list.Count; i++)
            {
                var p = list[i]; 

                json += "  {\n";
                json += $"    Name: {p.Name},\n";
                json += $"    Age: {p.Age},\n";
                json += $"    CreatedAt: {p.CreatedAt:f},\n";
                json += $"    MiddleName: {p.MiddleName},\n";
                json += $"    Score: {p.Score}\n";
                json += "  }";

                if (i < list.Count - 1) json += ",";
                json += "\n";
            }
            json += "]";

            File.WriteAllText(fileName, json);
        }
    }
}
