using lab7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Models
{
    public class Car : Transport, IMaintainable
    {
        public string FuelType { get; set; }
        public int Doors { get; set; }
        public string GearBox { get; set; }
        public string Color { get; set; }

        public Car(string brand, int speed, int year, string model, string fuelType, int doors, string gearBox, string color)
            : base(brand, speed, year, model)
        {
            FuelType = fuelType;
            Doors = doors;
            GearBox = gearBox;
            Color = color;
        }

        public override string GetInfo()
        {
            return $"Автомобіль: {Brand} {Model}, Паливо: {FuelType}, Дверей: {Doors}, Колір: {Color}";
        }

        public void PerformMaintenance()
        {
            Console.WriteLine($"Автомобіль {Brand} {Model} проходить технічне обслуговування.");
        }
    }
}
