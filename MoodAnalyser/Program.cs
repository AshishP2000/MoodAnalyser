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
            //UC-3 Inform user if entered invalid mood
            Console.WriteLine("Welcome to Mood Analyser");

            MoodAnalysers moodAnalyser = new MoodAnalysers("");
            Console.WriteLine(moodAnalyser.Analyse()); 

            Console.ReadLine();
        }
    }
}
