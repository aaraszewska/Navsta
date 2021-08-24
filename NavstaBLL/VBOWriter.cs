﻿using System;
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


            File.AppendAllLines(filePath, firstSample.ChannelNames.Except(firstSample.standardChannel));
        }


         // / <summary>
        /// Add units to vbo file.Note that we don't add units for the standard channels
        //</summary>
        // <param name = "units" ></ param >
        public void WriteUnits(VBOSample firstSample)
        {
            File.AppendAllText(filePath, Environment.NewLine);
            var VBOUnits = new List<string>();
            var VBOChannelNames = new List<string>();
            var VBOStandardChannel = new List<string>();
            var VBONoStandardChannel = new List<string>();
            var units = new List<string>();
            VBOUnits.Add("[channel units]\n");

            firstSample.ChannelNames.ForEach(s =>
            {

                VBOChannelNames.Add(s);



            });

            firstSample.standardChannel.ForEach(p =>
            {

                VBOStandardChannel.Add(p);

            });

            var channel1 = VBOChannelNames.Except(VBOStandardChannel);
            VBONoStandardChannel.AddRange(channel1);
            firstSample.Units.ForEach(u =>
            {
                units.Add(u);
            });


            for (int j = 0; j < VBOChannelNames.Count(); j++)
            {
                var channel = VBOChannelNames[j];
                if (!VBOStandardChannel.Contains(channel))

                {

                    VBOUnits.Add(units[j]);

                }


            }

            File.AppendAllLines(filePath, VBOUnits);
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

            List<string> VBOStandardColumnNames = new List<string>() { "sats", "time", "lat", "long", "velocity", "heading", "height", "vert-vel" };
            var respon = string.Join(" ", VBOStandardColumnNames);
            VBOStandardColumnNames.Add(respon);
            File.AppendAllText(filePath, respon);

            var temp = firstSample.ChannelNames.Except(firstSample.standardChannel);

            var temp2 = string.Join(" ", temp);
            VBOColumnNames.Add(temp2);

            File.AppendAllText(filePath, temp2);
        }

        /// <summary>
        /// ADD DATA to VBO file
        /// </summary>
        /// <param name="vboSamples"></param>
        public void WriteVBOData(List<VBOSample> samples)
        {

            File.AppendAllText(filePath, Environment.NewLine);
            var VBOData = new List<string>();

            VBOData.Add("[data]\n");
            File.AppendAllText(filePath, Environment.NewLine);
            //TODO: standard channels first in [data] section

            File.AppendAllLines(filePath, VBOData);
            var VBOChannelNames = new List<string>();
            var VBOStandardChannel = new List<string>();
           

             samples.First().ChannelNames.ForEach(s =>
            {

                VBOChannelNames.Add(s);



            });//get channelnames


            samples.First().standardChannel.ForEach(p =>
            {

                VBOStandardChannel.Add(p);
                
            });//get standard chanell
               //

           


            var VBONoStandardChannel = new List<string>();
            var channel1  = VBOChannelNames.Except(VBOStandardChannel);
            VBONoStandardChannel.AddRange(channel1);
            
         





            samples.ForEach(samples => //pobira satandard 
            {
                // tworzysz listę stringów

                var VBOStandard = new List<string>();
                var VBORest = new List<string>();
                for (int j = 0; j < VBOChannelNames.Count(); j++)
                {

                    var channel = VBOChannelNames[j];
                    
                    if (!VBONoStandardChannel.Contains(channel))

                    
                    {
                        // dodajesz element standardowego kanało do listy
                        VBOStandard.Add(samples.Data[j]);

                    }
                    else
                    {
                        VBORest.Add(samples.Data[j]);
                    }

                }


                //var res = string.Join(" ", VBOStandard) + string.Join(" ", VBORest);
                //File.AppendAllText(filePath, res);
                VBOStandard.Reverse();
                var res = string.Join(" ", VBOStandard);
                File.AppendAllText(filePath, res);
                File.AppendAllText(filePath, "\r\n");
                res = string.Join(" ", VBORest);
                File.AppendAllText(filePath, res);
                File.AppendAllText(filePath, "\r\n");





            });

            











        }
    }
}




































































































