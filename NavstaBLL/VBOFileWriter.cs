using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    ///<summary>this file is responsible for writing a vbo file including it's header and data</summary>
    ///
    public class VBOFileWriter
    {
        public static void NewVbo()
        {
            string filePath = @"C:\Users\Anna\Desktop\Test1.txt";
            List<string> lines = new List<string>();// lista stringow 
            lines = File.ReadAllLines(filePath).ToList();

            
            foreach (String line in lines)
            {

                string[] items = line.Split("\t");
                
                TimeSpan time = TimeSpan.FromSeconds(54243.22);
                items[23] = time.ToString(@"hh\:mm\:ss");
                Console.WriteLine(items[23]);

            }

                  Console.ReadLine();






        }
    }

}









       



        

    

