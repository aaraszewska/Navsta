
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    ///<summary>Responsible for reading data from a abd robot.It will expose a list of abd data model</summary>

    ///add a method for getting a channel ordinal position for a channel name

    ///add a method for reading entire robot file into memory

    /*we're very interested in the standard channels: 
    satellites
    time
    latitude
    longitude
    velocity kmh
    heading
    height

    ...so assume that you will have properties on a data model for these fields. The other channels can just be an array or list of channels. We can do this bit later - let's focus on the standard channels first.

    */
    // metody
    //
    public class ABDRobotDataReader
    {
        //we will hold the list of data model here. The data model contains only 1 row from the txt.
        private List<ABDRobotData> _robotdata = new List<ABDRobotData>();//we have list of object
        //lista modeli danych lista zawiera tylko 1 wiersz z txt


        /// <summary>
        ///  method for reading entire robot file into memory abdatarobot collection robot data
        /// </summary>
        public void ReadRobotFile()
        {

            string filePath = @"C:\Users\Anna\Desktop\Test.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            lines.RemoveRange(0, 3);
            List<string> chanelNames = lines[0].Split("\t").ToList<string>();
            //lines.RemoveRange(0,5);
            lines.ForEach(line => {
                List<string> data = line.Split("\t").ToList<string>();

                _robotdata.Add(new ABDRobotData(chanelNames, data));
            });
           
            
            Console.ReadLine();
        }
    }
}


















































































