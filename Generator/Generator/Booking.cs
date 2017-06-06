using System;
using System.Collections.Generic;
using System.IO;

namespace Generator
{
    public class Booking
    {
        private static Random r = new Random();
        
        private static byte[] gender = new byte[] { 0, 1 };
        
        private static List<String> firstName = new List<string>();
        
        private static List<String> lastName = new List<string>();

        private static List<char> firstLetter = new List<char>();

        private static void getFirstName()
        {
            String source = File.ReadAllText(@"D:\Database\Source\FirstName.txt");
            foreach (var row in source.Split('\n'))
            {
                firstName.Add(row);
            }
        }

        private static void getLastName()
        {
            String source = File.ReadAllText(@"D:\Database\Source\LastName.txt");
            foreach (var row in source.Split('\n'))
            {
                lastName.Add(row);
            }
        }

        private static String getName()
        {
            int i = r.Next(1, firstName.Count) - 1;
            var fName = firstName[i];
            var lName = lastName[r.Next(1, lastName.Count) - 1];
            return fName + " " + lName;
        }

        private static void getFirstLetter()
        {
            //char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            for (char c = 'A'; c <= 'Z'; c++)
                firstLetter.Add(c);
        }

        private static DateTime RandomDay()
        {
            DateTime begin = new DateTime(2016, 3, 1);
            DateTime end = new DateTime(2016, 4, 30);
            int range = (end - begin).Days;
            return begin.AddDays(r.Next(range));
        }

        private static String getPassportSeries()
        {
            return firstLetter[r.Next(0, firstLetter.Count - 1)].ToString() + r.Next(12345678, 99999999).ToString();
        }

        public static void Generate(int size)
        {
            getFirstName();
            getLastName();
            getFirstLetter();

            var bookings = new List<string>();

            for (int bookingID = 1; bookingID <= size; ++bookingID)
            {
                int flightID = r.Next(1, 500);
                String passportNumber = getPassportSeries();
                String passName = getName();
                int passAge = r.Next(18, 80);
                int passGender;
                if (r.NextDouble() > 0.5)
                    passGender = gender[1];
                else
                    passGender = gender[0];

                bookings.Add(string.Format("{0};{1};{2};{3};{4};{5};{6}\n",
                                    bookingID, flightID, passportNumber, passName, passAge, passGender, RandomDay()));
            }

            File.WriteAllLines(@"D:\Database\Source\Bookings.txt", bookings);
        }
    }
}
