using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace DistrictPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> districts = new Dictionary<string, int>();

            // Add district and its population
            districts.Add("District 1", 100000);
            districts.Add("District 2", 150000);
            districts.Add("District 3", 200000);
            districts.Add("District 4", 175000);

            // Print all districts and their populations
            foreach (KeyValuePair<string, int> district in districts)
            {
                Console.WriteLine(district.Key + ": " + district.Value);
            }
        }
    }
}