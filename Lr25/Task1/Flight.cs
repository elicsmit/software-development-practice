using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Flight
    {
        private string name;
        private string description;
        private long id;
        private DateTime createdAt;


        Flight(string name, string description, long id, DateTime createdAt) {
            this.name = name;
            this.description = description;
            this.id = id;
            this.createdAt = createdAt;

        }


    }
}
