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
        public Seat[] MaximumOccupancy { get; set; }
        public Motor Engine { get; set; }
        public Odometer Odometer { get; set; }
        public FuelTank FuelTank { get; set; }

        public Car()
        {
            Make = "Porsche";
            Model = "Boxster";
            Color = "Silver";
            Engine = new Motor(10);
            Odometer = new Odometer(0);
            FuelTank = new FuelTank();
            MaximumOccupancy = new Seat[2];

            // Fill the car with passengers
            for (int i = 0; i < MaximumOccupancy.Length; i++)
            {
                MaximumOccupancy[i] = new Seat(true);
            }
        }
        public Car(string make, string model, string color, int maxOccupancy, int currentOccupancy, double fuelEfficiency, double fuelTankCapacity, double fuelLevel, int odometer)
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy = new Seat[maxOccupancy];
            Engine = new Motor(fuelEfficiency);
            Odometer = new Odometer(odometer);
            FuelTank = new FuelTank(fuelTankCapacity, fuelLevel);

            // Fill the car with passengers
            for (int i = 0; i < maxOccupancy; i++)
            {
                if(i < currentOccupancy)
                    MaximumOccupancy[i] = new Seat(true);
                else
                    MaximumOccupancy[i] = new Seat();
            }
        }

        public void Drive(int km = 5)
        {
            // Checks if someone is sitting in the driver seat, if so it drives the car
            if (MaximumOccupancy[0].Occupied == false) // Would work with checking GetPassengers(), but wouldn't work if driver moved into passenger seat so I changed this.
            {
                Console.WriteLine("And who's supposed to drive?");
            }
            else
            {
                FuelTank.BurnFuel(km / Engine.FuelEfficiency);
                Odometer.Increment(km);
            }

        }

        public override string ToString()
        {
            return $"A {Color} {Make} {Model} with {GetOdometerWithZeros()}KM on the odometer, {GetFuelStatus()} "+NumOfPassengersResponse();
        }

        public string GetFuelStatus()
        {
            return FuelTank.Level == 0 ? "that has no fuel left." : $"that has enough fuel to travel {GetAvailableKms()}KM.";
        }

        public double GetAvailableKms()
        {
            return Math.Round(FuelTank.Level * Engine.FuelEfficiency, 0);
        }

        public string NumOfPassengersResponse()
        {
            string stringPassengers;
            int numPassengers = GetPassengers();
            switch (numPassengers)
            {
                case 0:
                    stringPassengers = "There is nobody inside.";
                    break;
                case 1:
                    stringPassengers = "There is just the driver inside.";
                    break;
                default:
                    stringPassengers = $"There are {numPassengers} people inside.";
                    break;
            }
            return stringPassengers;
        }

        public int GetPassengers()
        {
            int numberOfPassengers = 0;

            foreach (Seat seat in MaximumOccupancy)
                if (seat.Occupied == true) numberOfPassengers++;

            return numberOfPassengers;
        }

        // Get odometer as string with zeroes for unused digits
        public string GetOdometerWithZeros()
        {
            string odo = "";
            for (int i = 1; i <= (6 - Odometer.Counter.ToString().Length); i++)
            {
                odo += "0";
            }
            return odo += Odometer.Counter.ToString();
        }
    }
}
