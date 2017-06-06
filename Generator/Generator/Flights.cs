using System;
using System.Collections.Generic;
using System.IO;

namespace Generator
{
    class Flights
    {
        //private static Dictionary<int, Dictionary<int, double>> time;
        private static Random r = new Random();

        private static double[,] time;

        private static int[] numberSeats = new int[] { 128, 132, 189, 522, 364, 373, 428 };

        private static void getFlightTimes()
        {
            time = new double[25, 25];

            String source = File.ReadAllText(@"D:\Database\Source\FlightTimes.txt");
            int i = 0, j;
            foreach (var row in source.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split('\t'))
                {
                    time[i, j] = double.Parse(col.Trim());
                    //if (time[i, j] < 0.0)
                    //    time[i, j] = Double.NaN;
                    j++;
                }
                i++;
            }
        }

        private static DateTime RandomDay()
        {
            DateTime begin = new DateTime(2016, 5, 1);
            DateTime end = new DateTime(2016, 7, 1);
            int range = (end - begin).Days;
            return begin.AddDays(r.Next(range));
        }

        private static DateTime TicketDate(DateTime current)
        {
            double gendate = r.NextDouble();
            gendate *= -30.0;
            return current.AddDays(gendate);
        }

        private static int GenPrice(double flightTime)
        {
            double standardPrice = flightTime * 100.0;  // USD
            double salePercent = r.NextDouble() * 0.5;  // maximum 50 %
            double price = standardPrice * (1.0 - salePercent);
            return (int)price;
        }

        public static void Generate(int size)
        {
            getFlightTimes();

            var flights = new List<string>();

            for (int flightID = 1; flightID <= size; ++flightID)
            {
                int airplaneID = r.Next(1, 7);
                int origin = r.Next(1, 25);
                int destination;

                while ((destination = r.Next(1, 25)) == origin || time[origin - 1, destination - 1] < 0.0)
                    ;

                double flightTime = time[origin - 1, destination - 1];

                DateTime departureTime = RandomDay();
                DateTime arrivalTime = departureTime.AddHours(flightTime);

                int freeSeats = r.Next(10, numberSeats[airplaneID - 1]);

                flights.Add(string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}",
                    flightID, airplaneID, r.Next(1, 9), r.Next(1, 15), origin, departureTime, destination, arrivalTime, 
                    freeSeats, GenPrice(flightTime), TicketDate(departureTime)));
            }

            File.WriteAllLines(@"D:\Database\Source\Flights.txt", flights);
        }

        public static void MapFlight()
        {
            getFlightTimes();

            List<string> map = new List<string>();

            for (int origin = 0; origin < 25; origin++)
            {
                for (int destination = 0; destination < 25; destination++)
                {
                    if (time[origin, destination] > 0.0)
                        map.Add(string.Format("{0};{1};{2};{3}",
                            origin + 1, destination + 1, time[origin, destination], GenPrice(time[origin, destination])));
                }
            }

            File.WriteAllLines(@"D:\Database\Source\FlightMap.txt", map);
        }
    }
}
