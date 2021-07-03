
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
        #region ReadData
        /// <summary>
        ///  method for reading entire robot file into memory
        /// </summary>
        public static void ReadRobotFile()
        {

            string filePath = @"C:\Users\Anna\Desktop\Test3.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            
        }
        #endregion

        #region GettingChanel

        /// <summary>
        /// method for getting a channel ordinal position for a channel name
        /// </summary>

        public static void ReadChanelPosition()
        {
            string filePath = @"C:\Users\Anna\Desktop\Test3.txt";
            


            List<string> headres = File.ReadLines(filePath).ToList();
            foreach (string line in headres)
            {
                
                string[] items = line.Split("\t");//mamy kolumny
                 
               // var  header = lines[5]; //tu mamy naglowki
                lines.Add(lines[5]);

               // var header = lines.Select(items => items[5]).ToList();
               // header.push(items[1]);
                Console.WriteLine();

                

            }
        }
        #endregion
    }
}

























