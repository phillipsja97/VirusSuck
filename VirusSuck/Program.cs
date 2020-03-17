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
            // add a new item to the list at a certain index
            names.Insert(0, "Shebola");

            // add multiple items by collection initializer {}, and using AddRange.
            var people = new List<string> { "Nathan", "Martin", "Randys Kid" };
            names.AddRange(people);

            // remove an item by name
            names.Remove("Stupidity");
            // remove an item by index
            names.RemoveAt(3);
            // remove multiple items
            names.RemoveRange(names.Count - 3, 3); //  this removes the people collection from above.

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //------------------------------------------------------------------
            // Dictionaries below
            //------------------------------------------------------------------

            //starting a dictionary
            var symptoms = new Dictionary<string, string>();
            // addding to a dictionary
            symptoms.Add("COVID-19", "Dry cough, fever, respiratory problems");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            //get single thing in dictionary by the key
            var covidSymptoms = symptoms["COVID-19"];

            //remove single item by the key
            symptoms.Remove("Ebola");

            //initializing a dictionary with multiple items
            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            // looping over the dictionary by the key and value

            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"I have the {virus} virus and my symptoms are {symptom}.");
            }

            // looping over the List and using the dictionary as well

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"I have the {name} virus and my symptoms are {symptoms[name]}.");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is unknown");
                }
            }

            //------------------------------------------------------------------
            // Queues below
            //------------------------------------------------------------------

            // instantiating the queue
            var diseasesToCure = new Queue<string>();
            // adding a queue
            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");
            // deleting a queue // first in, first out type collection. Whatever went in first, gets deleted first. Have to move through the collection. 
            var thingToCure = diseasesToCure.Dequeue(); // the value deleted will go into a variable. and so on.
            var nextThingToCure = diseasesToCure.Dequeue();

            //------------------------------------------------------------------
            // Hashsets below
            //------------------------------------------------------------------

            // vectors will store 1 instance of an addition, even if it is added more than once.

            var vectors = new HashSet<string>();

            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");

            // End examples.

            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry Cough");
            covid19.Symptoms.Add("Cancels everything except work.");
            covid19.NumberOfDeathsWorldWide = 7150;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry Cough");
            spanishFlu.NumberOfDeathsWorldWide = 50000000;

            var rabies = new Virus("Rabies", 2);
            rabies.Symptoms.Add("Fever");
            rabies.Symptoms.Add("Excess salivation");
            rabies.NumberOfDeathsWorldWide = 200000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies };

            foreach ( var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an icubation period of {virus.IncubationDays} days and has killed {virus.NumberOfDeathsWorldWide} people.");
                Console.WriteLine($"It has the following symptoms : {string.Join(",", virus.Symptoms)}");
            }

        }
    }
}
