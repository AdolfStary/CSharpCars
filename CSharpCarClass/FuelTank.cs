using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCarClass
{
    class FuelTank
    {
        private double _capacity;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }
        private double _level;
        public double Level 
        {
            get
            {
                return _level;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Don't have enough fuel for the action.");
                }

                if (value > Capacity) _level = Capacity;
                else _level = value;
                
            }
        }

        public FuelTank(double capacity = 50, double level = 50)
        {
            Capacity = capacity;
            Level = level;
        }

        public void BurnFuel(double liters = 0)
        {
            Level = Level - liters;
        }

        public void Fill(double liters = 0)
        {
            Level = Level + liters;
        }

    }
}
