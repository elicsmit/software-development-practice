using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1_23
{
    public class Animal
    {
        [XmlAttribute("Nick")]
        public string Name { get; set; }

        //[XmlElement("Kind")] 
        public string Species { get; set; }

        [XmlElement("YearsOld")]
        public int Age { get; set; }

        [XmlIgnore] 
        public string SecretNotes { get; set; }
    }
}
