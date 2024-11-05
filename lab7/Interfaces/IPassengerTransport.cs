using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Interfaces
{
    public interface IPassengerTransport
    {
        int PassengerCapacity { get; set; }
        void LoadPassengers(int count);
    }
}
