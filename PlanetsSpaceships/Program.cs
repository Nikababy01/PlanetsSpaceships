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
            //Iterating over the ships first, then over then the planets

            var spacecraftNames = new Dictionary<string, List<string>>
            {
                {
                    "Spacecraft",
                        new List<string> { "Earth", "Mars", "Mercury"}
                }
            };
            foreach (var (ship, definitions) in spacecraftNames)
            {
                Console.WriteLine($"The {ship} has traveled to planets.");
                foreach (var definition in definitions)
                {
                    Console.WriteLine($" {definition}");
                }
            }
            //1. first create the first dictionary list
            var rockyplanets = new Dictionary<string, List<string>>();
            //2. next create a list of spacecrafts
            var rockyPlanetShips = new List<string> { "Rocky XX1", "Rocky IV" };
            var nonrockyPlanetShips = new List<string> { "FireBox II", "FireStarter III" };
            //3. Then add to that list using Add. passing in a string and a dictionary list
            rockyplanets.Add("Mercury", rockyPlanetShips);
            rockyplanets.Add("Venus", rockyPlanetShips);
            rockyplanets.Add("Jupiter", nonrockyPlanetShips);
            rockyplanets.Add("Neptune", nonrockyPlanetShips);

            //4. foreach over and use key and value

            foreach (var planet in rockyplanets)
            {
                Console.WriteLine($"The planet {planet.Key} has been visited by these spaceships: {string.Join(", ", planet.Value)}.");
            }
        }
    }
}
