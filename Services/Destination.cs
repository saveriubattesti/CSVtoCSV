using DataContracts;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Destination
    {
       
        public static String generateCSV(List<List<Block>> columns)
        {
            var stringCSV = "";
            var nbRow = columns[0].Count;
            for(int i = 0; i<nbRow; i++)
            {
                foreach(List<Block> column in columns)
                {
                    stringCSV += column[i].Entry + ";";
                }

                    stringCSV += "\n";
                
            }

            return stringCSV;

        }

    }
}
