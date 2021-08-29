﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        public double Heading { get; set; }
        public double Height { get; set; }

        #region Get string versions of standard channels for writing to the vbo file
        
        #endregion

        #region Properties for non-standard channels

        //we need to hold a dymanic list of non-standard channels
        public List<string> ChannelNames = new List<string>();
        public List<dynamic> Data = new List<dynamic>();
        public List<string> Units = new List<string>();
        public List<string> NoStandardChannel = new List<string>();
        public List<string> StandardChannel = new List<string>();

        public string TimeForVBO { get; set; }
       
            
           
            
        

        //TODO: add public standard channels list here (static)
        //TODO: check how to create list with items in 1 statement (rather than separately calling .Add afterwards)

        public List<string> standardChannel = new List<string> { "Satellites", "MP time", "Latitude", "Longitude","Velocity_Kmh", "True_Heading" };

        #endregion


        public VBOSample()
        {

        }
    }
}







































#endregion