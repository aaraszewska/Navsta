using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NavstaBLL
{
    public class VBOSample

    {



        #region Properties for standard channels
        public int Satellites { get; set; }
        public DateTime Time { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Velocity { get; set; }
        public double Heading { get; set; }
        public double Height { get; set; }

        #endregion

        #region Properties for non-standard channels

        //we need to hold a dymanic list of non-standard channels
        public List<dynamic> noStandardChanels = new List<dynamic>();
        //we also need units
        public List<string> dataUnits = new List<string>();
        //we also need channel names
        public List<VBOSample> _standardChanels = new List<VBOSample>();


        private Dictionary<string, dynamic> _vbosample;

        #endregion

        public VBOSample()
        {

        }




        public VBOSample(List<string> chanelNames, List<string> standardChanel, List<string> dataUnits,List<string>data)
        {

            var MS = chanelNames.Except(standardChanel).ToList();//create nostandardchanels
            var QS = (from num in chanelNames
                      select num)
                     .Except(standardChanel).ToList();
            QS.ForEach(item =>
            {

                noStandardChanels.Add(item);

            });
            dataUnits = new List<string>();
           
        }
        // / <summary>
        // / somehow we need to create the VBO samples
        // / </summary>

        //loop around robot samples

        //create new vbo sample and add to list
       // List.Add
        public VBOSample(List<string> dataUnits, List<string> standardChanel, List<string> data)
        {
            _vbosample = new Dictionary<string, dynamic>();
            int index = 0;
            standardChanel.ForEach(name =>
                {
                    string value = data[index];
                    _vbosample.Add(name, value);
                    index++;
                });




        }

    }
}






















