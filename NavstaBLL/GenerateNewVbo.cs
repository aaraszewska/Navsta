using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
   public class GenerateVbo
    {

       public static void GenerateDocuments()
        {
           
            Console.WriteLine("Insert time");
            var time =   Console.ReadLine();

            var tamplate = File.ReadAllText("C:\\Users\\Anna\\Desktop\\Test2.txt");
            var document = tamplate.Replace("time1", time);

            File.WriteAllText($"C:\\Users\\Anna\\Desktop\\TestNew.txt", document);
        }
    }
}
