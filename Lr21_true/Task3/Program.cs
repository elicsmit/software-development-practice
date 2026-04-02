using System;
using System.Collections.Generic;
using Task3;

class Program
{
    static void Main()
    {

        var people = new List<Person>
        {
            new Person { Name = "Ivan", Age = 25, CreatedAt = DateTime.Now, MiddleName = "Ivanovich", Score = 90 },
            new Person { Name = "Anna", Age = 20, CreatedAt = DateTime.Now, MiddleName = null, Score = 85 }, 
            new Person { Name = "Boris", Age = 30, CreatedAt = DateTime.Now, MiddleName = "Victorovitch", Score = null },
            new Person { Name = "Anna", Age = 19, CreatedAt = DateTime.Now, MiddleName = "Sergeevna", Score = 95 },
            new Person { Name = "Dmitry", Age = 17, CreatedAt = DateTime.Now, MiddleName = "Olegovich", Score = 70 } 
        };

      
        var service = new PersonService();

        try
        {
            service.ProcessAndSave(people);
            Console.WriteLine("Готово! Результаты записаны в файл service.json");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
