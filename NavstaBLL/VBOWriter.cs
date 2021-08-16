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
            VBOHeader.Add("[header]");
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
        public void WriteUnits(List<VBOSample>samples)
        {
            var VBOUnits = new List<string>();
            VBOUnits.Add("[channel units]");
            samples.First().AdditionalChannelUnits.ForEach(r =>
            {
               // samples.First().AdditionalChannelUnits.Where(x=> )
                
                VBOUnits.Add(r);

                
            });
           
    






            File.AppendAllLines(filePath, VBOUnits);
            //File.AppendAllLines(filePath, new List<string>()
            //        {
            //            "[channel units]",
                        

            //        }) ;
        }



       

            

            /// <summary>
            /// ADD DATA to VBO file
            /// </summary>
            /// <param name="vboSamples"></param>
            public void WriteVBOData(List<VBOSample> samples)//??where to get the date from sample????
        {
            var VBOData = new List<string>();
            VBOData.Add("[data]");
            samples.First().AdditionalChannelData.ForEach(r =>
            {
               
                VBOData.Add(r);
            });

            File.AppendAllLines(filePath, VBOData);
            //File.AppendAllLines(filePath, new List<string>()//add list of string
            //{
            //    "[data]",
                

            //}); ;

           
            


        }


    }
}








       














    

