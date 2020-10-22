﻿using System;
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
            Make = "Porsche";
            Model = "Boxster";
            Color = "Silver";
            MaximumOccupancy = 2;
            FuelEfficiency = 10;
            Odometer = new Odometer(182000);
            FuelTank = new FuelTank();
        }
        public Car(string make, string model, string color, int maxOccupancy, double fuelEfficiency, double fuelTankCapacity, double fuelLevel, int odometer)
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy = maxOccupancy;
            FuelEfficiency = fuelEfficiency;
            Odometer = new Odometer(odometer);
            FuelTank = new FuelTank(fuelTankCapacity, fuelLevel);
        }

        public void Drive(int km = 5)
        {
            FuelTank.BurnFuel( km/FuelEfficiency );
            Odometer.Increment( km );
        }

        public override string ToString()
        {
            string stringOdometer = "";
            double availableKms =Math.Round(FuelTank.Level / FuelEfficiency, 0);
            string fuelStatus = FuelTank.Level == 0 ? "that has no fuel left." : $"that has enough fuel to travel {availableKms}KM.";

            for (int i = 1; i < (6 - Odometer.Counter.ToString().Length); i++)
            {
                stringOdometer += "0";
            }
            stringOdometer += Odometer.Counter.ToString();

            return $"A {Color} {Make} {Model} with {stringOdometer} on the odometer, {fuelStatus}";
        }
    }
}
