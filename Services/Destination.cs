using CsvHelper;
using CsvHelper.Configuration;
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

        public static void Submit(String Path, List<Block> blocks)
        {
            using (var writer = new StreamWriter(Path + ".csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(blocks);
            }
        }

        public static void AddEntry(List<Block> blocks, String entryName)
        {
            int newBlockId = blocks.Count + 1;

            blocks.Add(new Block() {Id = newBlockId, Entry = entryName });
        }
    }
}
