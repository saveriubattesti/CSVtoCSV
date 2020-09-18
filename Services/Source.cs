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
    }
}
