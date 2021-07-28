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
        public int Satellites => _robotData["MpSatellites"];
        public DateTime Time => _robotData["MpTime"];
        public double Latitude => _robotData["MpLatitude"];
        public double Longitude => _robotData["MpLongitude"];
        public float Velocity => _robotData["MpVelocity"];
        public double Heading => _robotData["MpHeading"];
        public double Height => _robotData["MpHeight"];

        #endregion

       
        private Dictionary<string, dynamic> _robotData;//dictionary//robot samples
        public ABDRobotData(List<string> chanelNames, List<string> data)
        {

            _robotData = new Dictionary<string, dynamic>();

            int index = 0;
            chanelNames.ForEach(name =>
            {
                string value = data[index];
                _robotData.Add(name, value);
                index++;
            });

            


        }
        public ABDRobotData ()
        {

        }
         
        ///<summary>
        ///Provides robot data dynamic list of data
        ///</summary>
        public Dictionary<string, dynamic> RobotData => _robotData;

        





    }

    public class Adddata
    {
        public string ChanelName { get; set; }
        public float ChanelData { get; set; }
    }




}








































