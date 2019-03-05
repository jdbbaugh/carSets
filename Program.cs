using System;
using System.Collections.Generic;

namespace carSets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Inventory = new List<string> ()
        {
            "Camry", "F-150", "MDX", "Camry", "Camry",
            "Taurus", "F-150", "MDX", "Camry", "Xterra",
            "Mustang", "Suburban", "Santa Fe", "F-150", "Camry",
            "F-150", "F-150", "Mustang", "Camry", "Camry",
            "Camry", "Escalade", "Q30", "Camry", "MDX",
        };

        HashSet<string> allModels = new HashSet<string>();

        foreach (string model in Inventory)
        {
            allModels.Add(model);
        }

        // Display all unique model names
        foreach (string vehicle in allModels)
        {
            // Console.WriteLine($"{vehicle}");
        }

        HashSet<string> showRoom = new HashSet<string>(){"g-bus", "911", "Diablo", "Diablo", "Vanagon"};


        HashSet<string> usedLot = new HashSet<string>(){"Impala", "Fiesta"};

        showRoom.UnionWith(usedLot);


        showRoom.Remove("Fiesta");
        showRoom.Remove("Vanagon");
        Console.WriteLine(showRoom.Count);


        }
    }
}
