using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Sreyas"},
                {"age", "28"}
            });

            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Tanuja"},
                {"age", "56"}
            });

            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Bhaskar"},
                {"age", "60"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }
        }

    }
}
