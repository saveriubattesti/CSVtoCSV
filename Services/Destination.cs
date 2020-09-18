using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Destination
    {
        /*
        public static void Submit(String PathTofile, String fileName, List<DataContracts.Block> blocks)
        {
            using (var writer = new StreamWriter(PathTofile + fileName + ".csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(blocks);
            }
        }
        */

        public static String ToMatrix(List<DataContracts.Block> blocks)
        {
            //var matrix = new String[10,10];

            var matrix = "";
            var old = 1;

            foreach (Block b in blocks)
            {
                
                if (b.Id == 1 && matrix !="") { matrix += "\r\n"; }


                for (int i = old; i < b.Id; i++)
                {
                    //if (b.Id - i != old && b.Id != 1) { matrix += ";"; }
                    if (b.Id - i != 1 && b.Id != 1) { matrix += ";"; }
                }


                matrix += b.Entry + ";";



                old = b.Id;
            }


            return matrix;
        }

    }
}
