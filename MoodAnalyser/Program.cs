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
            //UC-1 Given a massage, ability to analyse  and respond happy or sad mood
            Console.WriteLine("Welcome to Mood Analyser");

            MoodAnalysers moodAnalyser = new MoodAnalysers("i am sad");
            Console.WriteLine(moodAnalyser.Analyse()); 

            Console.ReadLine();
        }
    }
}
