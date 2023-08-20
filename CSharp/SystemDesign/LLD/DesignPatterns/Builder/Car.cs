using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public string Color;
    }

    // new Car ("make", "model", 2023, "white")

    public class CarBuilder
    {
        private Car car = new Car();
        public CarBuilder SetMake(string make)
        {
            // other advantage is to do validations on pa particular property
            if (string.IsNullOrEmpty(make))
            {
                throw new NotImplementedException();
            }
            car.Make = make;
            return this;
        }
        public CarBuilder SetModel(string model)
        {
            car.Model  = model;
            return this;
        }
        public CarBuilder SetYear(int year)
        {
            car.Year = year;
            return this;
        }
        public CarBuilder SetColor(string color)
        {
            car.Color = color;
            return this;
        }

        public Car Build()
        {
            return car;
        }
    }
}
