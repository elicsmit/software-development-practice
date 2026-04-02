using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_24
{
    public class Flight
    {
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }

        public override string ToString()
        {
            return $"Рейс {FlightNumber} в {Destination}, вылет: {DepartureDate:dd.MM.yyyy}";
        }
    }
}
