using System;
using System.Collections.Generic;

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
        public int Satellites => DataValues[ChannelNames.IndexOf("MpSatellites")];

        public DateTime Time => DataValues[ChannelNames.IndexOf("MpTime)")];
       
        public double Latitude => DataValues[ChannelNames.IndexOf("MpLatitude")];
        public double Longitude => DataValues[ChannelNames.IndexOf("MpLongitude")];
        public float Velocity => DataValues[ChannelNames.IndexOf("MpVelocity")];
        public double Heading => DataValues[ChannelNames.IndexOf("MpHeading")];
        public double Height => DataValues[ChannelNames.IndexOf("MpHeight")];

        #endregion


       // private Dictionary<string, dynamic> _robotData;//dictionary//robot samples
       List<Tuple<string, string,dynamic>> _robotdata = new List<Tuple<string,string,dynamic>>();
        
        _robotdata.Add(new Tuple<string, string,dynamic>(ChanelNames, "foo"));
        
        //private List<(string channelKey, string units, dynamic datavalue)> _robotdata;


        public List<string> ChannelNames { get; set; }
        public List<string> Units { get; set; }

        public List<dynamic> DataValues { get; set; }



        public ABDRobotData(List<string> channelNames, List<string> data,List<string>dataUnits)
        {

            // _robotData = new Dictionary<string, dynamic>();
            DataValues = new List<dynamic>();
            Units = new List<string>();
            ChannelNames = new List<string>();
           

            int index = 0;
            channelNames.ForEach(name =>
            {
                string value = data[index];
                DataValues.Add(value);
                ChannelNames.Add(name);
              
                
                //_robotData.Add(name, value);
                index++;
                
            });

            int i = 0;
            dataUnits.ForEach(units =>
            {
                Units.Add(units);
            });


        }
       
        public ABDRobotData ()
        {

        }
         
        ///<summary>
        ///Provides robot data dynamic list of data
        ///</summary>
        //public Dictionary<string, dynamic> RobotData => _robotData;

        





    }

    public class Adddata
    {
        public string ChanelName { get; set; }
        public float ChanelData { get; set; }
    }




}








































