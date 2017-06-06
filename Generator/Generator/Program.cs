using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Flights.Generate(500);
            Booking.Generate(2000);
            
            Flights.MapFlight();
        }
    }
}
