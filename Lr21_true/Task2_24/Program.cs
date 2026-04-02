using Task2_24;

class Program
{
    static void Main()
    {

        IFlightControl<Flight> system = new AirlineSystem<Flight>();

        system.Add(new Flight { FlightNumber = "SU-100", Destination = "Москва", DepartureDate = new DateTime(2023, 10, 15) });
        system.Add(new Flight { FlightNumber = "FZ-900", Destination = "Дубай", DepartureDate = new DateTime(2023, 11, 20) });

        Console.WriteLine("Список рейсов (управление через интерфейс):");
        system.ShowAll();
    }
}
