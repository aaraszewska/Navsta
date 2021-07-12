using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    /// <summary>
    /// This class is responsible for holding the data structure of the abd data
    /// initially we want properties for the standard channels. Later we will handle channels that are not known until runtime
    /// </summary>
    public class ABDRobotData
    {

        #region Properties
        public int Satellites { get; set; }
        public DateTime Time { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Velocity { get; set; }
        public double Heading { get; set; }
        public double Height { get; set; }
        #endregion

        public List<string> ChanelName { get; set; } = new List<string>();
        public List<float> ChanelData { get; set; } = new List<float>();
        public List<(string Chanelname, float chanelValue)> AdditionalChanels { get; set; } = new List<(string chanelname, float chanelValue)>();



    }
    //tuple dynamic list of chanels data 2 independent list
    //list of tuple


    public class Adddata
    {
        public string ChanelName { get; set; }
        public float ChanelData { get; set; }
    }


   
}


























