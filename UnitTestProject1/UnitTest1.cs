using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[DataRow("I am in HAPPY mood","happy")]
        //[DataRow("I am in SAD mood","sad")]
        [DataRow(null)]
        public void TestMethod1(string msg)
        {
            ///AAA
            //Arrange
            string excepted = "happy";
            MoodAnalysers moodAnalyser = new MoodAnalysers(msg);

            //Act
            string actual = moodAnalyser.Analyse();

            //Assert
            Assert.AreEqual(excepted,actual);
        }
    }
}
