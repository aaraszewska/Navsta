using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
    public class OpenFile
    {
        public static void ReadFile()
        {
            
            // File name  
            string filePath = @"C:\Users\Anna\Desktop\Test.txt";

            List<string> lines = new List<string>();//tworze nowa liste
            
            lines = File.ReadAllLines(filePath).ToList();// zapisuje dane do listy
            
            foreach (String line in lines)// robie literacje po wszystkich linijkach
            {
                line.Split("\t").ToList();
                Console.WriteLine(line);//wypisuje linie 
                File.WriteAllLines(filePath, lines);//zpisuje

            }
            List<string>.Enumerator em = lines.GetEnumerator();
            
            int i = 0;
            //System.Collections.IEnumerator myEnumerator = lines.GetEnumerator();
            
            while ((em.MoveNext()) && (em.Current != null))
                Console.WriteLine("[{24}] {100}", i++, em.Current);
        }



        



}
    
}
    

    //.Split("\t")
