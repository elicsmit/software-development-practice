using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_24
{
    public class FlightManager
    {
        public void RescheduleFlights<T1, T2>(T1 flight, T2 system)
            where T1 : Flight
            where T2 : IFlightControl<T1>
        {
            Console.WriteLine($"Перепланирование рейса: {flight}");
            system.Add(flight);
        }
    }
}
