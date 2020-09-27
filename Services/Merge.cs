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
        public override List<Block> CreateBlock(List<Block> entryBlocks, Dictionary<string, string> parameters, int nbOfOutputBlocks = 1)
        {
            if (nbOfOutputBlocks != 1)
            {
                return entryBlocks;
            }

            String mergedString = "";
            Int32 finalId = entryBlocks.FirstOrDefault().Id;


            for (int i = 0; i < entryBlocks.Count(); i++)
            {
                var mergeChar = parameters["mergeChar"];
                if (i > 0)
                {
                    mergedString += mergeChar;
                }
                mergedString += entryBlocks[i].Entry;
            }

            List<Block> outputBlocks = new List<Block>();
            outputBlocks.Add(
                 new Block() { Id = finalId, Entry = mergedString }
            );
            
            return outputBlocks;
        }

        public static List<Block> MergeBis(List<List<Block>> colums, Int32[] idColumsShouldBeMerged, char separator)
        {
            List<Block> columnsMerged = new List<Block>();
            List<List<Block>> allColums = new List<List<Block>>();
            foreach (Int32 element in idColumsShouldBeMerged)
            {
                allColums.Add(colums[element]);
            }
            var nbColumns = idColumsShouldBeMerged.Length;
            var idColumn = idColumsShouldBeMerged[0];
            var n = 0;
            
            foreach(Block row in allColums[0])
            {
                for(int i = 1; i<nbColumns; i++)
                {
                 columnsMerged.Add(new Block { Id = n, Entry = row.Entry + separator + allColums[i][n].Entry });

                }
                n++;
            }


            return columnsMerged;
        }
    }
}
