using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //[DataRow("I am in HAPPY mood", "happy")]
        //[DataRow("I am in SAD mood", "sad")]
        //[DataRow(null)]
        //public void TestMethod1(string msg)
        //{
        //    ///AAA
        //    //Arrange
        //    string excepted = "happy";
        //    MoodAnalysers moodAnalyser = new MoodAnalysers(msg);

        //    //Act
        //    string actual = moodAnalyser.Analyse();

        //    //Assert
        //    Assert.AreEqual(excepted, actual);
        //}

        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalysers moodAnalyser = new MoodAnalysers(message);
                string mood = moodAnalyser.Analyse();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty",e.Message);
            }
        }
    }
}
