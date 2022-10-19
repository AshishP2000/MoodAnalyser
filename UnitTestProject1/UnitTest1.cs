using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("I am in HAPPY mood","happy")]
        [DataRow("I am in SAD mood","sad")]
        [DataRow("I am in ANY mood","hapy")]
        public void TestMethod1(string msg,string excepted)
        {
            ///AAA
            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers(msg);

            //Act
            string actual = moodAnalyser.Analyse();

            //Assert
            Assert.AreEqual(excepted,actual);
        }
    }
}
