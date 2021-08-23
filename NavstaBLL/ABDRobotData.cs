using System;
using System.Collections.Generic;
using System.Linq;

namespace NavstaBLL
{
    /// <summary>
    /// This class is responsible for holding the data model/structure of the abd data for robots
    /// initially we want properties for the standard channels. Later we will handle channels that are not known until runtime
    /// </summary>
    public class ABDRobotData
    {

        #region Channel mapping for VBO standard channels
        /// <summary>
        /// 
        /// </summary>
        /// 
        public int Satellites => Convert.ToInt32(DataValues[ChannelNames.IndexOf("MpSatellites")]);
        public DateTime Time => Convert.ToDateTime(DataValues[ChannelNames.IndexOf("MpTime)")]);

        public double Latitude => Convert.ToDouble(DataValues[ChannelNames.IndexOf("MpLatitude")]);
        public double Longitude => Convert.ToDouble(DataValues[ChannelNames.IndexOf("MpLongitude")]);
        public float Velocity => float.Parse(DataValues[ChannelNames.IndexOf("MpVelocity")]);
        public double Heading => Convert.ToDouble(DataValues[ChannelNames.IndexOf("MpHeading")]);
        public double Height => Convert.ToDouble(DataValues[ChannelNames.IndexOf("MpHeight")]);

        #endregion


        //private Dictionary<string, dynamic> _robotData;//dictionary//robot samples
       
        
        


        public List<string> ChannelNames { get; set; }
        public List<string> Units { get; set; }

        public List<dynamic> DataValues { get; set; }
        public List<string>VBOStandardChannel { get; set; }
        public List<string> VBONoStandardChannel { get; set; }



        public ABDRobotData(List<string> channelNames, List<string> data, List<string>dataUnits)
        {

            //_robotData = new Dictionary<string, dynamic>();
            DataValues = new List<dynamic>();
            Units = new List<string>();
            ChannelNames = new List<string>();
          //  Data = new List<string>();

           var VBOChannelNames = new List<string>();
            var VBOStandardChannel = new List<string>();
            var VBONoStandardChannel = new List<string>();
             List<string> standardChannel = new List<string>{"Satellites","Time","Latitude","Longitude","Velocity kmh","hHading",
        "Height"};

            int index = 0;
            channelNames.ForEach(name =>
            {
            DataValues.Add(data[index]);
            ChannelNames.Add(name);

                Units.Add(dataUnits[index]);

                index++;

            });
            ChannelNames.ForEach(s =>
            {

                VBOChannelNames.Add(s);



            });

            standardChannel.ForEach(p =>
            {

                VBOStandardChannel.Add(p);

            });




            var chanel = VBOChannelNames.Except(VBOStandardChannel);
            foreach (var val in chanel)
            {


                VBONoStandardChannel.Add(val);

            }

            //var respons = string.Join(" ", VBONoStandardChannel);
            //VBONoStandardChannel.Add(respons);


           

        }











    }


    ///<summary>
    ///Provides robot data dynamic list of data
    ///</summary>
    //public Dictionary<string, dynamic> RobotData => _robotData;







}













































