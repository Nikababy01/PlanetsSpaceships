using System;
using System.Collections.Generic;


namespace PlanetsSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Juptier");
            planetList.Add("Saturn");
            List<string> lastplanetList = new List<string>() { "Uranus", "Neptune" };
            
            planetList.AddRange(lastplanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("and Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);
           planetList.Remove("and Pluto");
    
            Console.WriteLine($"I love the solar system and the planets are: {string.Join(",", planetList)}.");
            Console.WriteLine($"There are 4 rocky planets and they are: {string.Join(", ", rockyPlanets)}.");

            Console.WriteLine("============================================================================");
            //Iterating over planets

            var spacecraftNames = new Dictionary<string,List<string>> ();
            {
                {
                    "Spacecraft1",
                        new List<String> { "Earth", "Mars", "Mercury" };
                }
            };
        }
    }
}
