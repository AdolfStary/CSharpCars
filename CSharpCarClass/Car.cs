using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCarClass
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelEfficiency { get; set; }
        public Odometer Odometer { get; set; }
        public FuelTank FuelTank { get; set; }

        public Car()
        {

        }

        public void Drive(double km = 5)
        {

        }

        public override string ToString()
        {
            string stringOdometer = "" + Odometer.Counter;
            string fuelStatus = "that has enough fuel to travel {}KM.";
            return $"A {Color} {Make} {Model} with {stringOdometer} on the odometer, {fuelStatus}";
        }
    }
}
