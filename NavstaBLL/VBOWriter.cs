using System;
using System.Collections.Generic;
using System.Globalization;
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
            File.AppendAllText(filePath, Environment.NewLine);
            var VBOHeader = new List<string>();

            VBOHeader.Add("[header]");
            firstSample.standardChannel.ForEach(s => //all channels
            {

                VBOHeader.Add(s.ToLower());

            });

            File.WriteAllLines(filePath, VBOHeader);
        }


        public void WriteNoStandardChannnel(VBOSample firstSample)
        {
            var VBONoStandardChannel = new List<string>();
            var VBOChannelNames = new List<string>();
            var VBOStandardChannel = new List<string>();
            firstSample.ChannelNames.ForEach(s =>
            {
                VBOChannelNames.Add(s);


            });
            firstSample.standardChannel.ForEach(p =>
            {
                VBOStandardChannel.Add(p);
            });
            var chanel = VBOChannelNames.Except(VBOStandardChannel);
            foreach (var val in chanel)
            {
                VBONoStandardChannel.Add(val);
            }

            File.AppendAllLines(filePath, VBONoStandardChannel);
        }










        // / <summary>
        /// Add units to vbo file.Note that we don't add units for the standard channels
        //</summary>
        // <param name = "units" ></ param >
        public void WriteUnits(List<VBOSample> samples)
        {
            File.AppendAllText(filePath, Environment.NewLine);
            var VBOUnits = new List<string>();
            VBOUnits.Add("[channel units]");
            samples.First().Units.ForEach(r =>
            {


                VBOUnits.Add(r);


            });








            File.AppendAllLines(filePath, VBOUnits);
            //File.AppendAllLines(filePath, new List<string>()
            //        {
            //            "[channel units]",


            //        }) ;
        }




        public void WriteComments(List<VBOSample> samples)
        {
            File.AppendAllText(filePath, Environment.NewLine);
            var VBOCommnets = new List<string>();
            VBOCommnets.Add("[comments]");
            File.AppendAllLines(filePath, VBOCommnets);

        }


        public void WriteModuleInformation(List<VBOSample> samples)
        {
            File.AppendAllText(filePath, Environment.NewLine);
            var VBOModuleInformation = new List<string>();
            VBOModuleInformation.Add("[module Information]");
            File.AppendAllLines(filePath, VBOModuleInformation);

        }
        public void WriteColumnNames(VBOSample firstSample)
        {
            File.AppendAllText(filePath, Environment.NewLine);
            File.AppendAllText(filePath, Environment.NewLine);

            var VBOColumnNames = new List<string>();
            
            VBOColumnNames.Add("[column names]");

            File.AppendAllLines(filePath, VBOColumnNames);
            
            var VBONoStandardChannel = new List<string>();
            var VBOChannelNames = new List<string>();
            var VBOStandardChannel = new List<string>();
            firstSample.ChannelNames.ForEach(s =>
            {
                VBOChannelNames.Add(s);


            });
            firstSample.standardChannel.ForEach(p =>
            {
                VBOStandardChannel.Add(p.ToLower());
            });
            var chanel = VBOChannelNames.Except(VBOStandardChannel);
            foreach (var val in chanel)
            {
                VBONoStandardChannel.Add(val);
            }
            File.AppendAllLines(filePath, VBOStandardChannel);
            File.AppendAllLines(filePath, VBONoStandardChannel);


        }
        




        /// <summary>
        /// ADD DATA to VBO file
        /// </summary>
        /// <param name="vboSamples"></param>
        public void WriteVBOData(List<VBOSample> samples)//??where to get the date from sample????
            {
                File.AppendAllText(filePath, Environment.NewLine);
                var VBOData = new List<string>();
                VBOData.Add("[data]");
                samples.First().Data.ForEach(r =>
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


    









       














    

