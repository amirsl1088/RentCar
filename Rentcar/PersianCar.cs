using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentcar
{
    public class PersianCar:Car
    {
        public PersianCar(string name,int model):base(name,model)
        {

        }
        public override void SetSpeed(int speed)
        {
            if (speed > 150)
            {
                throw new Exception("wrong speed");
            }
            base.SetSpeed(speed);
        }
    }
}
