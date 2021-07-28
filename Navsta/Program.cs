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
            var robotdata = dataReader.GetRobotFile();

            List<VBOSample> vboSamples = new MyConverter().ToVBOSample(robotdata);

            var vbowriter = new VBOWriter();

            vbowriter.WriteVBOHeader();
            vbowriter.WriteVBOSamples(vboSamples);

            //_vbodata.Add(new VBOSample(chanelNames, standardChanel, dataUnits, data));
            //_nostandardchanels.Add(new VBOSample(chanelNames, standardChanel, data));
            //_vbosample.Add(new VBOSample(standardChanel, data, dataUnits));


            //List<VBOSample> vbosample2 = new List<VBOSample>();
            //ABDRobotData rd = new ABDRobotData();
            //VBOSample sample = new VBOSample
            //{
            //    Satellites = rd.Satellites,
            //    Time = rd.Time,
            //    Latitude = rd.Latitude,
            //    Longitude = rd.Longitude,
            //    Velocity = rd.Velocity,
            //    Heading = rd.Heading,
            //    Height = rd.Height
            //};
            //vbosample2.Add(sample);





        }
        public List<VBOSample> _vbosample = new List<VBOSample>();
       
        
        
         

        
       
    }
}
                
             



        

                //loop around robot samples

                ////create new vbo sample and add to list
                //List.Add
                //new VBOSample { Heading = rd.Heading, Satellites = rd.Satellites, }

                //somehow we need to create the VBO samples
                //we already have the robot samples - so we need to convert them into vbo samples.

                // vBOSample.known_channels();

                // vboReader.ReadVboData();














