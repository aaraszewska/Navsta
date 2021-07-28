using NavstaBLL;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace NavstaTests
{
    [TestFixture]
    public class ABDRobotDataReaderTest

    {
        

        [SetUp]
        public void Setup()
        {
           

        }

        [Test]
        public void CheckIsDataLoadedCorectly()
        {
            //Averrange
            ABDRobotDataReader reader = new ABDRobotDataReader();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Files", "Test.txt");
            List<string> lines = new List<string>();
            //Act
            //Assert
        }
        
    }
}