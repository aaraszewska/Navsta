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
        public List<string> units = new List<string>();
        //we also need channel names
        public List<VBOSample> _standardChanels = new List<VBOSample>();
        public List<string> _vbounits = new List<string>();

        private Dictionary<string, dynamic> _vbosample;

        #endregion






        public VBOSample(List<string> chanelNames, List<string> standardChanel)
        {
            
            var MS = chanelNames.Except(standardChanel).ToList();
            var QS = (from chanel in chanelNames
                      select chanel)
                      .Except(standardChanel).ToList();
            QS.ForEach(item =>
            {
                List<dynamic> noStandardChanels = new List<dynamic>();
                noStandardChanels.Add(item);
                
            });
            
        }
        /// <summary>
        /// somehow we need to create the VBO samples
        /// </summary>
        
        public VBOSample(List<string>dataUnits,List<string>noStandardChanel,List<string>data)
        {
            _vbosample = new Dictionary<string, dynamic>();
            int index = 0;
            noStandardChanel.ForEach(name =>
            {
                string value = data[index];
                _vbosample.Add(name, value);
                index++;
            });

            int count = 0;
            dataUnits.ForEach(units =>
            {
                string value = noStandardChanel[count];
                _vbounits.Add(units);
                count++;

            });
        }

       

    }
}




















