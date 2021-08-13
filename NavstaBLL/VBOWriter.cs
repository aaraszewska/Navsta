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
        // / <summary>
        /// write the vbo file from the VBOSamples
        /// </summary>
        List<VBOSample> VBOHeader = new List<VBOSample>();
       
        string filePath = "C:\\Users\\Anna\\Desktop\\Recelogic Task\\Navsta\\Navsta\\Files\\TestOutput.txt";

        public VBOWriter(string filePath)
        {
            //create a property for filepath
            this.filePath = filePath;
           
        }
        
       // /take the channel names from the first sample and write them into the vbo header section


        public void WriteVBOHeader(VBOSample firstSample)
        {
            
            var VBOHeader = new List<string>();
            VBOHeader.Add("[Header]");
            firstSample.AdditionalChannelNames.ForEach(s => //all channels
            {
               
                VBOHeader.Add(s);

               File.WriteAllLines(filePath, VBOHeader);

            });




        }

        // / <summary>
        /// Add units to vbo file.Note that we don't add units for the standard channels
        //</summary>
        // <param name = "units" ></ param >
        public void WriteUnits(List<string> units)//??where to get the units from????
        {
          
            

            File.AppendAllLines(filePath, new List<string>()
                    {
                        "[channel units]",
                        
                        
                    }) ;
        }
        

            


        

        /// <summary>
        /// ADD DATA to VBO file
        /// </summary>
        /// <param name="vboSamples"></param>
        public void WriteVBOData(List<VBOSample> samples)//??where to get the date from sample????
        {
           
            

            

            File.AppendAllLines(filePath, new List<string>()//add list of string
            {
                "[data]",

                
            });
           

           
        }
        
        
    }
}








       














    

