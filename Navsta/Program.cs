using NavstaBLL;
using System;

namespace Navsta
{
    class Program
    {
        static void Main(string[] args)
        {

           
           ABDRobotDataReader.ReadRobotFile();
           ABDRobotDataReader.ReadChanelPosition();
            
            Console.ReadKey();
        }
    }
}
