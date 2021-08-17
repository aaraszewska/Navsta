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
            

            

            var vbowriter = new VBOWriter("C:\\Users\\Anna\\Desktop\\Recelogic Task\\Navsta\\Navsta\\Files\\TestOutput.txt");

            vbowriter.WriteVBOHeader(vboSamples.First());
            vbowriter.WriteNoStandardChannnel(vboSamples.First());
            
            vbowriter.WriteUnits(vboSamples);
            vbowriter.WriteComments(vboSamples);
            vbowriter.WriteModuleInformation(vboSamples);
            vbowriter.WriteColumnNames(vboSamples.First());
            vbowriter.WriteVBOData(vboSamples);
            









        }
        public List<VBOSample> _vbosample = new List<VBOSample>();
       
        
        
         

        
       
    }
}
                
             



        

                














