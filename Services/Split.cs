using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;

namespace Services
{
    public class Split : Functoid
    {

        public override List<List<Block>> CreateBlock(List<List<Block>> columns, List<int> idColumnsShouldBeChange, char separator)
        {
            List<List<Block>> columnsSplitted = new List<List<Block>>();
            List<List<Block>> allColums = new List<List<Block>>();
            foreach (Int32 element in idColumnsShouldBeChange)
            {
                allColums.Add(columns[element]);
            }
            var nbColumns = idColumnsShouldBeChange.Count();
            var idColumn = idColumnsShouldBeChange[0];
            var n = 0;

            foreach (Block row in allColums[0])
            {
                if (n == 0)
                {
                    n++;
                    continue;
                }
                String[] rowSplitted = row.Entry.Split(separator);
                if (n == 1)
                {
                    for (int i = 0; i < rowSplitted.Length; i++)
                    {
                        columnsSplitted.Add(new List<Block>());

                    }
                }
                for (int i = 0; i < rowSplitted.Length; i++)
                {

                    columnsSplitted[i].Add(new Block { Id = n, Entry = rowSplitted[i] });

                }
                n++;
                Array.Clear(rowSplitted, 0, rowSplitted.Length);
            }

            for (int i = 0; i < columnsSplitted.Count(); i++)
            {

                columnsSplitted[i].Insert(0, new Block { Id = n, Entry = "split" + i });

            }

            return columnsSplitted;
        }
    }
}
