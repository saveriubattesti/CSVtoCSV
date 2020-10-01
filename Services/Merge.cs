using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;

namespace Services
{
    public class Merge : Functoid
    {

        public override List<List<Block>> CreateBlock(List<List<Block>> columns, List<int> idColumnsShouldBeChange, char separator)
        {
            List<List<Block>> columnsMerged = new List<List<Block>>();
            List<List<Block>> allColums = new List<List<Block>>();
            foreach (Int32 element in idColumnsShouldBeChange)
            {
                allColums.Add(columns[element]);
            }
            var nbColumns = idColumnsShouldBeChange.Count();
            var idColumn = idColumnsShouldBeChange[0];
            var n = 0;
            columnsMerged.Add(new List<Block>());
            foreach (Block row in allColums[0])
            {
                for (int i = 1; i < nbColumns; i++)
                {
                    columnsMerged[0].Add(new Block { Id = n, Entry = row.Entry + separator + allColums[i][n].Entry });

                }
                n++;
            }
            return columnsMerged;
        }
    }
}
