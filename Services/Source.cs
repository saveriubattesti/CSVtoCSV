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
                return lBlock;
            }


        }

        //Retourne la liste des colonnes du csv
        public List<List<DataContracts.Block>> MakeColunms(String link, List<Block> headers)
        {
            using (var reader = new StreamReader(link))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Read();
                csv.ReadHeader();
                var nbColumns = headers.Count();
                String value;
                var nb = nbColumns+1;
                List<List<Block>> columns = new List<List<Block>>();
                List<Block> listElement = new List<Block>();

                Int32 k = 1;
                foreach (Block title in headers)
                {
                    listElement.Add(new Block { Id = k, Entry = title.Entry });
                    k++;
                }
                while (csv.Read())
                {
                    for (int i = 0; csv.TryGetField<string>(i, out value); i++)
                    {
                            listElement.Add(new Block { Id = nb, Entry = value });
                            nb++;
                    }
                }
              
                var j = 1;
                var modulo = nbColumns;
                while (nbColumns != 0)
                {
                    
                    List<Block> column = new List<Block>();
                    foreach (Block el in listElement)
                    {
                        if(el.Id%modulo == j )
                        {
                            column.Add(el);
                        }
                        
                    }
                    j++;
                    if (j == modulo) {
                        j = 0;
                    }      
                    columns.Add(column);
                    nbColumns--;
                }

                return columns;

            }
        }
    }
}
