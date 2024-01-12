using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentcar
{
   public class Car
    {
        public Car(string name,int model)
        {
            Name = name;
            Model=model;
        }
        public string Name { get; set; }
        public int Speed { get;private set; }
        public int Model { get; set; }
        public int Price { get; set; }
        public virtual void SetSpeed(int speed)
        {
            if (speed < 0)
            {
                throw new Exception();
            }
            Speed = speed;
        }
    }
}
