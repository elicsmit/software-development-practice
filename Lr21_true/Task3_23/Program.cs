using System;
using System.IO;
using System.Collections.Generic;
using Task3_23;

public class MySerializer
{
    public void Save(Zoo zoo, string path)
    {
        List<string> lines = new List<string>();
        foreach (var a in zoo.Animals)
            lines.Add($"{a.Name},{a.Species},{a.Age}");

        File.WriteAllLines(path, lines);
    }

    public Zoo Load(string path)
    {
        Zoo zoo = new Zoo();
        foreach (var line in File.ReadAllLines(path))
        {
            var p = line.Split(',');
            zoo.Animals.Add(new Animal { Name = p[0], Species = p[1], Age = int.Parse(p[2]) });
        }
        return zoo;
    }
}
