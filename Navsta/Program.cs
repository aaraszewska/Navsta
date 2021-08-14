using NavstaBLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Navsta
{
    class Program
    {
        static void Main(string[] args)
        {

            ABDRobotDataReader dataReader = new ABDRobotDataReader();
            var robotdata = dataReader.GetRobotFile();

            List<VBOSample> vboSamples = new MyConverter().ToVBOSample(robotdata);
            List<VBOSample> firstSample = new List<VBOSample>(vboSamples);


            //vboSamples.First().

            var vbowriter = new VBOWriter("C:\\Users\\Anna\\Desktop\\Recelogic Task\\Navsta\\Navsta\\Files\\TestOutput.txt");

            vbowriter.WriteVBOHeader(vboSamples.First());
            
            // vbowriter.WriteUnits();
            vbowriter.WriteVBOData(vboSamples);









        }
        public List<VBOSample> _vbosample = new List<VBOSample>();
       
        
        
         

        
       
    }
}
                
             



        

                














