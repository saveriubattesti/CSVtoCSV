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
        public abstract List<List<Block>> CreateBlock(List<List<Block>> columns, List<Int32> idColumnsShouldBeChange, char separator);
    }
}
