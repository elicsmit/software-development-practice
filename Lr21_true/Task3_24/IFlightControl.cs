using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_24
{
    public interface IFlightControl<T> where T : Flight
    {
        void Add(T item);
        void ShowAll();
    }
}
