﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;

namespace Services
{
    public class Merge : Functoid
    {
        public override List<Block> CreateBlock(List<Block> entryBlocks, Dictionary<string, string> parameters, int nbOfOutputBlocks)
        {
            if (nbOfOutputBlocks <= 1)
            {
                return entryBlocks;
            }

            String mergedString = "";
            Int32 finalId = entryBlocks.FirstOrDefault().Id;

            foreach (Block entryBlock in entryBlocks)
            {
                mergedString += entryBlock.Entry;
            }

            List<Block> outputBlocks = new List<Block>();
            outputBlocks.Add(
                 new Block() { Id = finalId, Entry = mergedString }
            );

            return outputBlocks;
        }
    }
}
