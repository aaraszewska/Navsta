using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    /// <summary>
    /// This class is responsible for holding the data model/structure of the abd data
    /// initially we want properties for the standard channels. Later we will handle channels that are not known until runtime
    /// </summary>
    public class ABDRobotData
    {
        private Dictionary<string, dynamic> _robotData;
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
            //foreach (var a in data)
            //{
            //    Console.WriteLine(a);
            //}


        }

        ///<summary>
        ///Provides robot data dynamic list of data
        ///</summary>
        public Dictionary<string, dynamic> RobotData => _robotData;


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
}

    public class Adddata
    {

        public string ChanelName { get; set; }
        public float ChanelData { get; set; }
    }










































