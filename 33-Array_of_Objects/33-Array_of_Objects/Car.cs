using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Array_of_Objects
{
    class Car
    {
        string model;
        double speed;

        public Car(string model, double speed)
        {
            this.model = model;
            this.speed = speed;
        }
        public void Go()
        {
            Console.WriteLine("{0} is driving at {1}m/h.", model, speed);
        }

    }
}
