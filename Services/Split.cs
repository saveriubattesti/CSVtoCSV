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
        public override List<Block> CreateBlock(List<Block> entryBlocks, Dictionary<string, string> parameters, int nbOfOutputBlocks)
        {
            Char[] splittingChar = null;
            List<Block> blockReturn = new List<Block>();

            foreach (KeyValuePair<String, String> key in parameters)
            {
                if (key.Key == "splitChar")
                {
                    splittingChar = key.Value.ToCharArray();
                    break;
                }
            }

            if (splittingChar != null)
            {
                int nbNewBlock = 0;
                foreach (Block block in entryBlocks)
                {
                    int i;
                    String[] result = block.Entry.Split(splittingChar);
                    for (i = 0; i < result.Length; i++)
                    {
                        blockReturn.Add(new Block() { Id = 100 + nbNewBlock, Entry = result[i] });
                        nbNewBlock++;
                        nbOfOutputBlocks--;
                        if (nbOfOutputBlocks <= 0) break;
                    }
                    if (nbOfOutputBlocks <= 0) break;
                }

                if (nbOfOutputBlocks > 0)
                {
                    for (int i = 0; i < nbOfOutputBlocks; i++)
                    {
                        blockReturn.Add(new Block() { Id = 100 + nbNewBlock, Entry = " " });
                        nbNewBlock++;
                    }
                }
            }

            return blockReturn;
        }
    }
}
