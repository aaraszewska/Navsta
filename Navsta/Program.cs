using NavstaBLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Navsta
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            ABDRobotDataReader dataReader = new ABDRobotDataReader();
            dataReader.GetRobotFile(); //need to return the list
           
           

        }

            

            //loop around robot samples

            ////create new vbo sample and add to list
            //List.Add
            //new VBOSample { Heading = rd.Heading, Satellites = rd.Satellites, }

            //somehow we need to create the VBO samples
            //we already have the robot samples - so we need to convert them into vbo samples.

            // vBOSample.known_channels();

            // vboReader.ReadVboData();


           
        
    }
}
