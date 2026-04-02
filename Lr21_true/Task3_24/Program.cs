using Task3_24;

class Program
{
    static void Main()
    {
        Flight flight = new Flight { FlightNumber = "SU-100", Destination = "Москва", DepartureDate = DateTime.Now };
        AirlineSystem<Flight> airline = new AirlineSystem<Flight>();
        FlightManager manager = new FlightManager();

        manager.RescheduleFlights(flight, airline);

        Console.WriteLine("\nСодержимое системы после перепланирования:");
        airline.ShowAll();
    }
}
