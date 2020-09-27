using DataContracts;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

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
                MakeColunms(link);
                return lBlock;
            }


        }

        public List<List<DataContracts.Block>> MakeColunms(String link)
        {
            using (var reader = new StreamReader(link))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Read();
                csv.ReadHeader();
                var nbCollumns = csv.Context.HeaderRecord.Length;
                String value;
                //var collumnId = 0;
                var nb = 1;
                List<List<Block>> collumns = new List<List<Block>>();
                List<Block> listElement = new List<Block>();

                while (csv.Read())
                {
                    for (int i = 0; csv.TryGetField<string>(i, out value); i++)
                    {
                            listElement.Add(new Block { Id = nb, Entry = value });
                            nb++;
                    }
                }
                var j = 1;

                while (nbCollumns != 0)
                {
                    
                    List<Block> collumn = new List<Block>();
                    foreach (Block el in listElement)
                    {
                        if(el.Id%4 == j)
                        {
                            collumn.Add(el);
                        }
                        
                    }
                    j++;
                    collumns.Add(collumn);
                    nbCollumns--;
                }


                Merge.MergeBis(collumns, new int[] { 0, 1 }, '-');
                return collumns;

            }
        }
    }
}
