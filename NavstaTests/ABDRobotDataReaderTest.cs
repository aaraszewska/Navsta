using NavstaBLL;
using NUnit.Framework;
using System.Collections.Generic;

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
            var ABDRobotDataReader = new ABDRobotDataReader();
            var result = ABDRobotDataReader.GetRobotFile();
            Assert.That(result, Is.EqualTo("Done"));
        }
        
    }
}