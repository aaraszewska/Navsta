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
        #region Private fields
        private int _satallites;
        private DateTime _time;
        private float _longitude;
        private float _latitude;
        private float _velocity;
        private float _heading;
        private float _height;
        #endregion

        #region Properties
        public int Saltellites
        {
            get { return _satallites; }
            set { _satallites = value; }
        }

        
        public DateTime Time
        {
            get { return _time; }
            set {
                TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(_time));
                var str  = time.ToString(@"hh\:mm\:ss");

                
            }
        }
       

        public float Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        

        public float Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        

        public float Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }
      

        public float Heading
        {
            get { return _heading; }
            set { _heading = value; }
        }
       

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        #endregion

        List<string> listOfChanels = new List<string>();
    }
}



