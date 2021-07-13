using NavstaBLL;
using System;
using System.Collections.Generic;

namespace Navsta
{
    class Program
    {
        static void Main(string[] args)
        {
            ABDRobotData robotData = new ABDRobotData();
            ABDRobotDataReader dataReader = new ABDRobotDataReader();
            dataReader.ReadRobotFile();


        Console.ReadKey();
        }
    } 
}
