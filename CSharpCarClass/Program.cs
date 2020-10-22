using System;

namespace CSharpCarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car porsche = new Car();
            Car honda = new Car("Honda","Civic","Gray", 5, 18, 55, 30, 182000);
            Car foundOnRoadDead = new Car("Ford", "F150", "Faded Black", 5, 3, 80, 60, 999980);

            Console.WriteLine(porsche.ToString());
            Console.WriteLine(honda.ToString());
            Console.WriteLine(foundOnRoadDead.ToString());

            porsche.Drive(150);
            honda.Drive(222);
            honda.FuelTank.Fill(50);
            foundOnRoadDead.Drive(50);


            Console.WriteLine("--------------------------------");
            Console.WriteLine(porsche.ToString());
            Console.WriteLine(honda.ToString());
            Console.WriteLine(foundOnRoadDead.ToString());

        }
    }
}
