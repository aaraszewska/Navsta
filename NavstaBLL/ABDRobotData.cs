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
        Dictionary<string, List<string>> ChanelName = new Dictionary<string, List<string>>();
        Dictionary<string, List<float>> ChanelValue = new Dictionary<string, List<float>>();
        
        Dictionary<string ,float> additionalChanels = new Dictionary<string, float>();

       
       
         
        //public List<(string chanelname, float chanelvalue)> additionalchanels { get; set; } = new List<(string, float)>();

        Dictionary<string, List<dynamic>> robotData = new Dictionary<string, List<dynamic>>();
        

        public ABDRobotData()
        {


            robotData.Add("Satelites", new List<dynamic>());
            robotData.Add("Time", new List<dynamic>());
            robotData.Add("Latitude", new List<dynamic>());
            robotData.Add("Longitude", new List<dynamic>());
            robotData.Add("Velocity", new List<dynamic>());
            robotData.Add("Heading", new List<dynamic>());
            robotData.Add("Height", new List<dynamic>());

            foreach(var i in robotData)
            {
                // Console.WriteLine(i.Key + "|" + i.Value);
             
            }


           
        }

        
        public void Append(string[] items)
        {


            TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(items[23]));
            robotData["Satelites"].Add(items[32]);
            robotData["Time"].Add(time.ToString(@"hh\:mm\:ss"));
            robotData["Latitude"].Add(items[31]);
            robotData["Longitude"].Add(items[30]);
            robotData["Velocity"].Add(items[4]);
            robotData["Heading"].Add(items[2]);
            robotData["Height"].Add(items[3]);
            
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
    }

    public class Adddata
    {
        /// <summary>
        /// 
        /// </summary>
        public string ChanelName { get; set; }//pola
        public float ChanelValue { get; set; }

      
    

    }


    




}


























