using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    public class VBOWriter
    {
        List<VBOWriter> writeVboHeader = new List<VBOWriter>();
        ///take the channel names from the first sample and write them into the vbo header section
        public void WriteVBOHeader(VBOSample firstSample)
        {
            firstSample.AdditionalChannelNames.ForEach(s =>
            {
                writeVboHeader.Add(new VBOWriter
                {
                    
                });


            });
                

            
            

        }

        public void WriteVBOSamples(List<VBOSample> samples)
        {
        }
    }
}
