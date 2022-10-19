using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Handle Exception if user provides invalid mood
            Console.WriteLine("Welcome to Mood Analyser");

            MoodAnalysers moodAnalyser = new MoodAnalysers(null);
            Console.WriteLine(moodAnalyser.Analyse()); 

            Console.ReadLine();
        }
    }
}
