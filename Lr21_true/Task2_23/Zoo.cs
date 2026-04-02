using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2_23
{
    public class Zoo
    {
        [JsonProperty("Residents")] 
        public List<Animal> Animals { get; set; } = new List<Animal>();
    }
}
