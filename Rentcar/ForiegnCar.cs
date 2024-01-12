using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentcar
{
    public class ForiegnCar:Car
    {
        public ForiegnCar(string name, int model):base(name,model)
        {
            Name = name;
            Model = model;
        }
        public override void SetSpeed(int speed)
        {
            if (speed > 250)
            {
                throw new Exception("wrong speed");
            }
            base.SetSpeed(speed);
        }
    }
}
