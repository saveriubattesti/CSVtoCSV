using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjet2
{
    class Destination
    {
       
        public static void Submit(String PathTofile, String fileName, List<Block> blocks)
        {
            using (var writer = new StreamWriter(PathTofile+fileName+".csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(blocks);
            }
        }


        public static void AddEntry(List<Block> blocks, String entryName)
        {

        }


        public static String ToMatrix(List<Block> blocks)
        {

            var matrix = "";
            var old = 1;

            foreach(Block b in blocks)
            {
                if (b.Id == 1) { matrix += "\r\n"; }


                for (int i = old; i< b.Id;i++)
                {
                    if (b.Id - i != old && b.Id != 1) { matrix += ";"; }
                }
                

                matrix += b.Entry + ";";
                
                

                old = b.Id;
            }


            return matrix;
        }
    }

    class Block 
    {

        public Int32 Id { get; set; }
        public String Entry { get; set; }
    }
}
