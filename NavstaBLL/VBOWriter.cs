using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    public class VBOWriter
    {
        /// <summary>
        /// 
        /// </summary>
        List<VBOSample> VBOHeader = new List<VBOSample>();
        
        ///take the channel names from the first sample and write them into the vbo header section
        
        public void WriteVBOHeader(VBOSample firstSample) 
        {

            var VBOHeader = new List<string>();
            firstSample.AdditionalChannelNames.ForEach(s => //all channels
            {
                string filePath = "C:\\Users\\Anna\\Desktop\\Recelogic Task\\Navsta\\Navsta\\Files\\TestOutput.txt";
                VBOHeader.Add(s);
                
                
                System.IO.File.WriteAllLines(filePath, VBOHeader);
            });

          


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vboSamples"></param>
        public void WriteVBOSamples(List<VBOSample> samples)
        {
            
            
        }


        
    }
}








        //TODO: now write to the physical file














    

