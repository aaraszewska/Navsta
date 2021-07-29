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

        public List<dynamic> AdditionalChannelNames = new List<dynamic>();
        //we also need units
        public List<string> AdditionalChannelUnits = new List<string>();
        //we also need channel names
        public List<string> AdditionalChannelData = new List<string>();
       
        


      
            

        #endregion






        public VBOSample(List<string> channelNames, List<string> standardChannel, List<string> dataUnits)
        {

            var MS = channelNames.Except(standardChannel).ToList();//create nostandardchanels
            var QS = (from num in channelNames
                      select num)
                     .Except(standardChannel).ToList();
            QS.ForEach(item =>
            {

                AdditionalChannelNames.Add(item);

            });

            dataUnits = new List<string>();






        }


        public VBOSample()
        {

        }

        // / <summary>
        // / somehow we need to create the VBO samples
        // / </summary>

        //loop around robot samples

        //create new vbo sample and add to list
        //         List.Add

        //public VBOSample(List<string> standardChanel, List<string> data)
        //{
        //    _vbosample = new Dictionary<string, dynamic>();
        //    int index = 0;
        //    standardChanel.ForEach(name =>
        //    {
        //        string value = data[index];
        //        _vbosample.Add(name, value);
        //        index++;
        //    });
        //}
    }
}



































