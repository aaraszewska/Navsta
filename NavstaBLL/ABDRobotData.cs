using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    /// <summary>
    /// This class is responsible for holding the data model/structure of the abd data for robots
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
           


        }

        ///<summary>
        ///Provides robot data dynamic list of data
        ///</summary>
        public Dictionary<string, dynamic> RobotData => _robotData;
        /// <summary>
        /// 
        /// </summary>
        public void ToVBOSample(string chanelName,string data)
        {
           

        }

       

    }

        public class Adddata
    {
        public string ChanelName { get; set; }
        public float ChanelData { get; set; }
    }
           

              
    
}








































