using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NavstaBLL
{
    
    public class NewTxt
    {
        /// <summary>
        /// The class reads a txt file converts Mpt Time to hh\:mm\:ss
        /// and writes to a new Txt file-outptFile
        /// </summary>
        public static void TimeExchange()
        {
            

            string filePath = @"C:\Users\Anna\Desktop\Test.txt";  
            List<string> lines = new List<string>();
            List<NewFile> outputFiles = new List<NewFile>(); 

            lines = File.ReadAllLines(filePath).ToList();
            
            lines.RemoveRange(0, 6);
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            foreach (string line in lines)
            {
                string[] items = line.Split("\t");//item jest stringiem
                

                TimeSpan time = TimeSpan.FromSeconds(Convert.ToDouble(items[23]));
                items[23] = time.ToString(@"hh\:mm\:ss");
                

                NewFile newFile = new NewFile(items[0], items[1],items[23]);
                   
                

                outputFiles.Add(newFile);
            }


            List<string> outContens = new List<string>();
            foreach (NewFile o in outputFiles)
            {

                Console.WriteLine(o);
                outContens.Add(o.ToString());

                
            }


            string outFile = @"C:\Users\Anna\Desktop\Test2.txt";
            File.WriteAllLines(outFile, outContens);

            Console.ReadLine();



        }










    }
        

           
        
    
}







       



       







    
    

    

    

   
