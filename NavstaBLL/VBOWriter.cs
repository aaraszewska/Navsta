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
       // List<VBOWriter> writeVboHeader = new List<VBOWriter>();
        ///take the channel names from the first sample and write them into the vbo header section
        public void WriteVBOHeader(VBOSample firstSample)
        {
            firstSample.ChannelNames.ForEach(s =>
            {
            
               
             
                //TODO: now write to the physical file

                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Files", "TestOutput.txt");

                List<string> xxx = new List<string>(System.IO.File.ReadAllLines(filePath));



            });

            

        }

        public void WriteVBOSamples(List<VBOSample> samples)
        {
        }
    }
}
