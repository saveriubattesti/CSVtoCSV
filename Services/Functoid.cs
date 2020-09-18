using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public abstract class Functoid
    {
        public abstract List<Block> CreateBlock(List<Block> entryBlocks, Dictionary<String, String> parameters, Int32 nbOfOutputBlocks);
    }
}
