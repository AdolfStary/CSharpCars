using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCarClass
{
    class Motor
    {
        public double FuelEfficiency { get; set; }

        public Motor(double fuelEfficiency)
        {
            FuelEfficiency = fuelEfficiency;
        }
    }
}
