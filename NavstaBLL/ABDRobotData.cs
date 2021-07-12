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

        Dictionary<string, List<dynamic>> data = new Dictionary<string, List<dynamic>>();
        public ABDRobotData()
        {
           

            data.Add("Satelites", new List<dynamic>());
            data.Add("Time", new List<dynamic>());
            data.Add("Latitude", new List<dynamic>());
            data.Add("Longitude", new List<dynamic>());
            data.Add("Velocity", new List<dynamic>());
            data.Add("Heading", new List<dynamic>());
            data.Add("Height", new List<dynamic>());

        }


        public void Append(string[] items)
        {


            TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(items[23]));
            data["Satelites"].Add(items[32]);
            data["Time"].Add(time.ToString(@"hh\:mm\:ss"));
            data["Latitude"].Add(items[31]);
            data["Longitude"].Add(items[30]);
            data["Velocity"].Add(items[4]);
            data["Heading"].Add(items[2]);
            data["Height"].Add(items[3]);

        }
        


        #region Properties
        public int Satellites { get; set; }
        public DateTime Time { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public float Velocity { get; set; }
        public double Heading { get; set; } //where
        public double Height { get; set; }//where
        #endregion

       // public List<string> ChanelName { get; set; } = new List<string>();
        //public List<float> ChanelData { get; set; } = new List<float>();
        

        


        public List<(string chanelname, float chanelvalue)> additionalchanels { get; set; } = new List<(string, float)>();

    }
    


    public class Adddata
    {
        public string ChanelName { get; set; }
        public float ChanelData { get; set; }
    }

   
}


























