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
        public Motor Engine { get; set; }
        public Odometer Odometer { get; set; }
        public FuelTank FuelTank { get; set; }

        public Car()
        {
            Make = "Porsche";
            Model = "Boxster";
            Color = "Silver";
            MaximumOccupancy = 2;
            Engine = new Motor(10);
            Odometer = new Odometer(0);
            FuelTank = new FuelTank();
        }
        public Car(string make, string model, string color, int maxOccupancy, double fuelEfficiency, double fuelTankCapacity, double fuelLevel, int odometer)
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy = maxOccupancy;
            Engine = new Motor(fuelEfficiency);
            Odometer = new Odometer(odometer);
            FuelTank = new FuelTank(fuelTankCapacity, fuelLevel);
        }

        public void Drive(int km = 5)
        {
            FuelTank.BurnFuel( km/Engine.FuelEfficiency );
            Odometer.Increment( km );
        }

        public override string ToString()
        {
            string stringOdometer = "";
            double availableKms =Math.Round(FuelTank.Level * Engine.FuelEfficiency, 0);
            string fuelStatus = FuelTank.Level == 0 ? "that has no fuel left." : $"that has enough fuel to travel {availableKms}KM.";

            for (int i = 1; i <= (6 - Odometer.Counter.ToString().Length); i++)
            {
                stringOdometer += "0";
            }
            stringOdometer += Odometer.Counter.ToString();

            return $"A {Color} {Make} {Model} with {stringOdometer}KM on the odometer, {fuelStatus}";
        }
    }
}
