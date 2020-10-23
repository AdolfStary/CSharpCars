using System;

namespace CSharpCarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car porsche = new Car();
            Car honda = new Car("Honda","Civic","Gray", 5, 1, 18, 55, 30, 999980);
            Car foundOnRoadDead = new Car("Ford", "F150", "Faded Black", 5, 0, 3, 80, 0.5, 25665);

            Console.WriteLine(porsche.ToString());
            Console.WriteLine(honda.ToString());
            Console.WriteLine(foundOnRoadDead.ToString());

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Attempting to get the Porsche to drive 150km.");
            porsche.Drive(150);
            Console.WriteLine("Attempting to get the Honda to drive 222km.");
            honda.Drive(222);
            Console.WriteLine("Filled up 50 liters of fuel in the Honda.");
            honda.FuelTank.Fill(50);
            Console.WriteLine("Attempting to get the Ford to drive 50km.");
            foundOnRoadDead.Drive(50);


            Console.WriteLine("--------------------------------");
            Console.WriteLine(porsche.ToString());
            Console.WriteLine(honda.ToString());
            Console.WriteLine(foundOnRoadDead.ToString());

        }
    }
}
