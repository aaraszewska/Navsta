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
         List<VBOSample> writeVboHeader = new List<VBOSample>();
        ///take the channel names from the first sample and write them into the vbo header section
        public void WriteVBOHeader(VBOSample firstSample)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Files", "TestOutput.txt");
            var VBOHeader = new List<string>();
            firstSample.standardChannel.ForEach(s =>
            {
                VBOHeader.Add(s);

            });

            File.WriteAllLines(filePath, VBOHeader);


        }

        public void WriteVBOSamples(List<VBOSample> samples)
        {
            List<VBOSample> writeVBOSamples = new List<VBOSample>();
            writeVboHeader.ForEach(r =>
            {
                writeVBOSamples.Add(new VBOSample
                {
                    



                }
            }); 
                    
            
            
           
        }







        //TODO: now write to the physical file














    }
}
