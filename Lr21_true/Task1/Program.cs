using Task1;

public class Program
{
   public static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Tom",
            Age = 27,
            CreatedAt = DateTime.Now,
            MiddleName = null,
            Score = null
        };

        string json = $"Name - {person.Name}\n" +
            $"Age - {person.Age}\n" + $"CreatedAt - {person.CreatedAt} \n" +
            $"MiddleName - {person.MiddleName} \n" + $"Score - {person.Score} \n";

        File.WriteAllText("model.json", json);
        Console.WriteLine("Записанные данные: ");
        Console.WriteLine(json);
    }
}