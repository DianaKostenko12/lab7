using lab7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Models
{
    public class Train : Transport, IPassengerTransport
    {
        public int Carriages { get; set; }
        public int PassengerCapacity { get; set; }
        public string Route { get; set; }
        public double TravelTime { get; set; }

        public Train(string brand, int speed, int year, string model, int carriages, int passengerCapacity, string route, double travelTime)
            : base(brand, speed, year, model)
        {
            Carriages = carriages;
            PassengerCapacity = passengerCapacity;
            Route = route;
            TravelTime = travelTime;
        }

        public override string GetInfo()
        {
            return $"Потяг: {Brand} {Model}, Вагонів: {Carriages}, Маршрут: {Route}, Час у дорозі: {TravelTime} годин";
        }

        public void LoadPassengers(int count)
        {
            Console.WriteLine($"Завантажено {count} пасажирів до потяга {Model}.");
        }
    }
}
