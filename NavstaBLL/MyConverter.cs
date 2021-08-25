using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    /// <summary>
    /// TODO: later we will change this class/method into an extension method as it will be nicer to use.
    /// </summary>

    public class MyConverter
    {


        /// <summary>
        /// convert robot data samples to vbo samples
        /// </summary>
        /// <param name="robotData"></param>
        /// <returns></returns>

        public List<VBOSample> ToVBOSample(List<ABDRobotData> robotData)
        {
            List<VBOSample> vbodata = new List<VBOSample>();
            // add a new vbo sample for each robot sample
            robotData.ForEach(r =>
            { //TODO: add remaining standard channels
              //add a new channel name, units, channel value for each robotdatafield that isn't a standard channel


                //  create what we can

                vbodata.Add(new VBOSample
                {
                    //set standard channels
                   // SatellitesStringForVBO = r.Satellites.ToString(),
                    //TimeStringForVBO = r.Time.ToString(),
                    //LatitudeStringForVBO = r.Latitude.ToString(),
                    //LongitudeStringForVBO = r.Latitude.ToString(),
                    //VelocitStringForVBO = r.Velocity.ToString(),
                    //HeadingStringForVBO = r.Heading.ToString(),
                    //HeightStringForVBO = r.Height.ToString(),


                    //now set all robot channels - we set the sample standard channels but then want to just copy all robot channels to vbo.
                    Data = r.DataValues,
                    Units = r.Units,
                    ChannelNames = r.ChannelNames,
                    StandardChannel = r.VBOStandardChannel,
                    NoStandardChannel = r.VBONoStandardChannel,




                }); ;



            });
            return vbodata;
        }
    }
}
                  

                   

                  
                        
                            
                                  

                                    

                                


                    


    


