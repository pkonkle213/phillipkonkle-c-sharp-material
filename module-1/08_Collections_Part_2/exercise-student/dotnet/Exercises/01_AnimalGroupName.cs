using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> pluralAnimals = new Dictionary<string, string>()
            {
                {"RHINO","Crash" },
                {"GIRAFFE","Tower" },
                {"ELEPHANT","Herd" },
                {"LION","Pride" },
                {"CROW","Murder" },
                {"PIGEON","Kit" },
                {"Flamingo","Pat" },
                {"DEER","Herd" },
                {"DOG","Pack" },
                {"CROCODILE","Float" }
            };

            if (animalName != null)
            {
                animalName = animalName.ToUpper();

                if (pluralAnimals.ContainsKey(animalName))
                {
                    return pluralAnimals[animalName];
                }
            }
            return "unknown";
        }
    }
}
