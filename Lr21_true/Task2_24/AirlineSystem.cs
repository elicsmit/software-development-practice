using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_24
{
    public class AirlineSystem<T> : IFlightControl<T> where T : class
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void ShowAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
