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
        public static void ReadFile()
        {


            string filePath = @"C:\Users\Anna\Desktop\Test.txt";  //tworzymy odwolanie do pliku
            List<string> lines = new List<string>(); //tworzymy liste stringow
            List<NewFile> outputFiles = new List<NewFile>(); //List of <T> tworzymy

            lines = File.ReadAllLines(filePath).ToList(); // nasze linie dodajemy do naszej listy

            foreach (string line in lines)
            {
                string[] items = line.Split("\t");// robimy splita na liscie


                TimeSpan time = TimeSpan.FromSeconds(54243.22);
                items[23] = time.ToString(@"hh\:mm\:ss");



                NewFile o = new NewFile(items[0], items[1], items[23]);//nowy file z tymi plikmi
               


                outputFiles.Add(o);//zapis
            }


            List<string> outContens = new List<string>();// create a new list


            foreach (NewFile o in outputFiles)//convert each to a string
            {
                Console.WriteLine(o);
                outContens.Add(o.ToString()); //add string to outContents dodaje nowe wartosci do nowej listy
            }


            string outFile = @"C:\Users\Anna\Desktop\Test2.txt";//path do zapisu nowego pliku
            File.WriteAllLines(outFile, outContens);// write alllines

            Console.ReadLine();



        }










    }
        

           
        
    
}







       



       







    
    

    

    

   
