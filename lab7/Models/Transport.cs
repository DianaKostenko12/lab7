using lab7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7.Models
{
    public class Transport : MyObject, ITransportable
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public Transport(string brand, int speed, int year, string model)
        {
            Brand = brand;
            Speed = speed;
            Year = year;
            Model = model;
        }

        public override string GetInfo()
        {
            return $"Транспорт: {Brand} {Model}, Швидкість: {Speed} км/год, Рік: {Year}";
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Brand} {Model} рухається зі швидкістю {Speed} км/год.");
        }
    }
}
