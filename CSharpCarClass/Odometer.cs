using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCarClass
{
    class Odometer
    {
        private int _counter;
        public int Counter 
        {
            get 
            {
                return _counter;
            } 
            set
            {
                if ((_counter + value) > 999999)
                {
                    _counter = (_counter + value) - 999999;
                }
                else _counter = value;
            }
        }

        public Odometer(int startingKm = 0)
        {
            Counter = startingKm;
        }

        public void Increment(int amount = 0)
        {
            Counter += amount;
        }
    }
}
