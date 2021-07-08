
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
        ///  method for reading entire robot file into memory abdatarobot collection robot data
        ///  //must return somethink.ma zwrocic list of sat,tim,lat,lon,vel,hea,hei
        /// </summary>
        public  void ReadRobotFile()
        {

            string filePath = @"C:\Users\Anna\Desktop\Test3.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            var robotData = new List<ABDRobotData>();
            //for each line you need to create a abdrobotdata model
            lines.ForEach(l => robotData.Add(new ABDRobotData() //specjalna akcja dla listy
            {
                Satellites = l.Split("\t")   //need split the lines columns by tab split kolumn dla kazdej lini
                Time = l.Split("\t")
                Latitude = l.Split("\t")
                Longitude = l.Split("\t")
                Velocity = l.Split("\t")
                Heading = l.Split("\t")
                Height = l.Split("\t")
            })); 

            // witch column is mptime
            //for each line you need to create a abdrobotdata column name for chanel whitch we looking 
            //




            


        }
        #endregion

        #region GettingChanel

        /// <summary>
        /// method for getting a channel ordinal position for a channel name
        /// </summary>

        public  void ReadChanelPosition()
        {
            string filePath = @"C:\Users\Anna\Desktop\Test3.txt";
            
            string[] lines = File.ReadAllLines(filePath);
           ;
            for (int y = 0; y < lines.Length; y++)
            {
                string[] columns = lines[y].Split('\t');
               
                
                for (int index = 0; index < columns.Length; index++)

                {
                    Console.WriteLine(index + ":" + columns[index]);
                    Console.ReadKey();
                }
            }
        }










    }
}

        #endregion
   


























