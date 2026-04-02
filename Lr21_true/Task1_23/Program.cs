using System.Xml.Serialization;
using Task1_23;

class Program
{
    static void Main()
    {
        string filePath = "zoo.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(Zoo));

        Zoo myZoo = new Zoo();
        myZoo.Animals.Add(new Animal { Name = "Симба", Species = "Лев", Age = 5, SecretNotes = "Любит мясо" });
        myZoo.Animals.Add(new Animal { Name = "Кеша", Species = "Попугай", Age = 2, SecretNotes = "Шумный" });

        using (Stream fs = new MemoryStream(16))
        {
            serializer.Serialize(fs, myZoo);
            Console.WriteLine("Данные успешно сериализованы в zoo.xml");
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            Zoo? loadedZoo = serializer.Deserialize(fs) as Zoo;

            Console.WriteLine("\nДанные, прочитанные из XML:");
            if (loadedZoo != null)
            {
                foreach (var animal in loadedZoo.Animals)
                {
                    Console.WriteLine($"Кличка: {animal.Name}, Вид: {animal.Species}, Возраст: {animal.Age}");
                }
            }
        }
    }
}
