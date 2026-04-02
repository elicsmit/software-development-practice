using System.Text.Json.Serialization;

namespace Task2_23
{
    public class Animal
    {
        [JsonPropertyName("Nickname")] 
        public string Name { get; set; }

        [JsonPropertyName("Species")] 
        public string Species { get; set; }

        [JsonPropertyName("Age")] 
        public int Age { get; set; }

        [JsonIgnore] 
        public string SecretNotes { get; set; }
    }
}
