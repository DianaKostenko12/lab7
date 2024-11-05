using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Models
{
    public class Express : Train
    {
        public bool IsHighSpeed { get; set; }
        public string ServiceClass { get; set; }
        public string Catering { get; set; }
        public bool WiFIAvailable { get; set; }

        public Express(string brand, int speed, int year, string model, int carriages, int passengerCapacity, string route, double travelTime,
                       bool isHighSpeed, string serviceClass, string catering, bool wiFIAvailable)
            : base(brand, speed, year, model, carriages, passengerCapacity, route, travelTime)
        {
            IsHighSpeed = isHighSpeed;
            ServiceClass = serviceClass;
            Catering = catering;
            WiFIAvailable = wiFIAvailable;
        }

        public override string GetInfo()
        {
            return $"Експрес: {Brand} {Model}, Клас обслуговування: {ServiceClass}, Швидкісний: {IsHighSpeed}, WiFi: {WiFIAvailable}";
        }
    }
}
