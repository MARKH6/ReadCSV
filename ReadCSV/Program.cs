using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSV
{
    class Program
    {
        static void Main(string[] args)
        {

            //User Info Table
            const string existingFile = @"..\..\ExistingFile.csv";
            List<string> lines = new List<string>();
            StreamWriter sw = new StreamWriter(@"..\..\NewFile.csv");

            using (StreamReader sr = new StreamReader(existingFile))
            {
                // 3
                // Use while != null pattern for loop
                string line;
                int count = 1;

                string[] record = new string[12];
                //string[] record = new string[44];
                string newline = string.Empty;

                while ((line = sr.ReadLine()) != null)
                {

                    record = line.Split(',');

                   
                    newline = String.Format("{0},{1},{2},{3},{4}",count,"Name-"+count, record[0], record[1], record[2]);

                    sw.WriteLine(newline);
                    count++;

                }

                sw.Close();
            }

        }
    }
}
