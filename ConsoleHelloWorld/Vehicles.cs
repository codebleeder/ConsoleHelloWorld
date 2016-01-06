using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld
{
    class Vehicle
    {
        private int num_of_wheels;
        public Vehicle(int n)
        {
            this.num_of_wheels = n;
            Console.WriteLine("wheels: {0}", n);
        }
    }

    class TwoWheeler : Vehicle
    {
        public TwoWheeler() : base(2) { }
    }

    class FourWheeler : Vehicle 
    {
        public FourWheeler() : base(4) { }
    }
}
