using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCarClass
{
    class Seat
    {
        public bool Occupied { get; set; }

        public Seat(bool occupied = false)
        {
            Occupied = occupied;
        }
    }
}
