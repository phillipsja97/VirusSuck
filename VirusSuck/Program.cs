using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new list
            var names = new List<string>();

            // add to that list by variable type 
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");

            // remove an item by name
            names.Remove("Stupidity");
            // remove an item by index
            names.RemoveAt(3);


        }
    }
}
