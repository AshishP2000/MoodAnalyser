using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysers
    {
        public string message;
        public MoodAnalysers(string message)
        {
            this.message = message;
        }
        public string Analyse()
        {

            if (message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}
