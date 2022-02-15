using System;
using System.Collections.Generic;
using System.Linq;

namespace core
{
    class Application
    {
        static void Main(string[] args)
        {
            string str = "Bop PoB klop polk";
            List<string> listTest = str.Split(' ').ToList();

            // List of processed words to avoid repeated processing
            List<string> alreadyProcessed = new List<string>();

            foreach (string word1 in listTest)
            {
                foreach (string word2 in listTest)
                {
                    if (word1 == word2)
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine("Bye!");
        }
    }
}