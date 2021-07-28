using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public List<VBOSample> _vbodata = new List<VBOSample>();
        public List<VBOSample> _vbounits = new List<VBOSample>();
        public List<VBOSample> _nostandardchanels = new List<VBOSample>();
        public List<VBOSample> _vbosample = new List<VBOSample>();
        
      

        /// <summary>
        ///  method for reading entire robot file into list abdatarobot collection robot data
        /// </summary>
        public  List<ABDRobotData> GetRobotFile()
        {


            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Files", "Test.txt");
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            List<string> chanelNames = lines[4].Split("\t").Distinct().ToList<string>();
            List<string> dataUnits = lines[5].Split("\t").Distinct().ToList<string>();
            lines.RemoveRange(0, 6);
            lines.ForEach(line =>
            {
                List<string> data = line.Split("\t").ToList<string>();

                List<string> standardChanel = new List<string>();

                standardChanel.Add("Satellites");
                standardChanel.Add("Time");
                standardChanel.Add("Latitude");
                standardChanel.Add("Longitude");
                standardChanel.Add("Velocity");
                standardChanel.Add("Heading");
                standardChanel.Add("Height");
                _robotdata.Add(new ABDRobotData(chanelNames, data));
                _vbodata.Add(new VBOSample(chanelNames, standardChanel,dataUnits,data));
                _nostandardchanels.Add(new VBOSample(chanelNames, standardChanel,data));
                _vbosample.Add(new VBOSample(standardChanel, data,dataUnits));
                
                
                


            });

            
            var robotData = _robotdata;
            return robotData;



        }

       
        

        
    }
}


















































































