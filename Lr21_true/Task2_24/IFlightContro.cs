using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_24
{
    public interface IFlightControl<T> where T : class
    {
        void Add(T item);
        void ShowAll();
    }
}
