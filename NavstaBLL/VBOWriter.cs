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
        
        public void WriteVBOHeader(VBOSample firstSample) //?????header = standardChannel + noStandard
        {

            var VBOHeader = new List<string>();
            firstSample.AdditionalChannelNames.ForEach(s =>
            {

                VBOHeader.Add(s);
               

            });

            


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="samples"></param>
        public void WriteVBOSamples(List<VBOSample> samples)//????write to the txt file here???
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Files", "TestOutput.txt");
            List<string> writeVBOSamples = new List<string>();
           

            //writeVBOSamples.Add();


            //????column name ???we need + header or not
            //



            File.WriteAllLines(filePath, writeVBOSamples);
        }


        
    }
}








        //TODO: now write to the physical file














    

