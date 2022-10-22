using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserCustomException : Exception
    {
        public ExceptionType exceptionType;
        public enum ExceptionType
        {
            NULL_MSG,
            EMPTY_MSG
        }

        public MoodAnalyserCustomException(ExceptionType exceptionType, string messege) : base(messege)
        {
            this.exceptionType = exceptionType;
        }
    }
}
