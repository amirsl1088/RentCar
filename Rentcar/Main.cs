using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentcar
{
     class Main
    {
        private static List<Car> _cars=new();
        
       public static void AddCar(string name,int speed,int model,int price,int type)
        {
            if (type == 1)
            {
                var Car = new ForiegnCar(name, model);
                Car.SetSpeed(speed);
                Car.Price = price;
                _cars.Add(Car);
            }
            if (type == 2)
            {
                var car = new PersianCar(name, model);
                car.SetSpeed(speed);
                car.Price = price;
                _cars.Add(car);
            }
        }
        public static List<Car> GetCars()
        {
            return _cars;
        }
        public static void RentCar(string name,int day)
        {
            var car = _cars.Find(_ => _.Name == name);
            if(car is null)
            {
                throw new Exception("wrong car");
            }
            car.Price *= day;
            Console.WriteLine("succesful rent");
            Console.WriteLine($"carname={name}, total price={car.Price}");
        }
       
    }
}
