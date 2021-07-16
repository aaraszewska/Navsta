using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double Heading { get; set; } //where
        public double Height { get; set; }//where
        public double VericalVelocity { get; set; }
        #endregion

        #region Properties for non-standard channels

        //we need to hold a dymanic list of non-standard channels

        //we also need units

        //we also need channel names

        #endregion


        public void  VBOData(string []chanelNames, string[]data)
        {
            foreach(var a in chanelNames)
            {

            }
        }
            //List<Dictionary<string, dynamic>> _samples;


            // _samples = new Dictionary<string, dynamic>();
            // List<Tuple<string, int>> channels = VBOSample.known_channels();


            //  int index = 0;

            // List<Tuple<string, int>> channels = VBOSample.known_channels();

            //public  List<Tuple<string, int>> known_channels()
            //{
            //    List<Tuple<string, int>> channels = new List<Tuple<string, int>>();
            //     channels.Add(new Tuple<string, int>("Satellites", 1));
            //     channels.Add(new Tuple<string, int>("Time", 2));
            //     channels.Add(new Tuple<string, int>("Latitude", 3));
            //     channels.Add(new Tuple<string, int>("Longitude", 4));
            //     channels.Add(new Tuple<string, int>("Velocity", 5));
            //     channels.Add(new Tuple<string, int>("Heading", 6));
            //     channels.Add(new Tuple<string, int>("Height", 7));
            //     channels.Add(new Tuple<string, int>("VerticalVelocity", 8));


            //     return channels;
            //}
        }










    }



    

}

    

