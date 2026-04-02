using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1_23
{
    [XmlRoot("CityZoo")]
    public class Zoo
    {
        [XmlElement("Animal")]
        public List<Animal> Animals { get; set; } = new List<Animal>();
    }
}
