using Task1_24;

class Program
{
    static void Main()
    {
        AirlineSystem<Flight> airline = new AirlineSystem<Flight>();

        airline.Add(new Flight { FlightNumber = "SU-100", Destination = "Москва", DepartureDate = new DateTime(2023, 10, 15) });
        airline.Add(new Flight { FlightNumber = "FZ-900", Destination = "Дубай", DepartureDate = new DateTime(2023, 11, 20) });

        Console.WriteLine("Список рейсов в системе:");
        airline.ShowAll();
    }
}