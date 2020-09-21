using DataContracts;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Source
    {
        public List<Block> getData(String link)
        {
            using (var reader = new StreamReader(link))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Read();
                csv.ReadHeader();
                string[] headerRox = csv.Context.HeaderRecord;
                var records = csv.GetRecords<dynamic>();
                var counterId = 0;
                List<Block> lBlock = new List<Block>();
                foreach (var title in headerRox)
                {
                    lBlock.Add(new Block { Id = counterId, Entry = title });
                    counterId++;
                }


                return lBlock;
            }
        }

        public List<Block> GetAllData()
        {
            using (var reader = new StreamReader("D:/AAA-M2/Projet Apocalypse/ConsoleApp1/test.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ",";
                csv.Read();
                csv.ReadHeader();
                var records = csv.GetRecords<dynamic>();
                List<Block> cellData = new List<Block>();
                foreach (var line in records)
                {
                    var colCount = 1;
                    foreach (var cell in line)
                    {
                        cellData.Add(new Block { Id = colCount, Entry = cell.Value });
                        colCount++;
                    }
                }
                return cellData;
            }
        }
    }
}
