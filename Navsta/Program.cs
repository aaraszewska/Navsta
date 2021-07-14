using NavstaBLL;
using System;
using System.Collections.Generic;

namespace Navsta
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ABDRobotDataReader dataReader = new ABDRobotDataReader();
            dataReader.ReadRobotFile();


        Console.ReadKey();
        }
    } 
}
