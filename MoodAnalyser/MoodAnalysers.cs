using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            try
            {
                if (message == null)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MSG, "Mood should not be Null");
                }
                else if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MSG, "Mood should not be Empty");
                }
                
                else if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
            catch (MoodAnalyserCustomException e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
            
        }
    }
}
