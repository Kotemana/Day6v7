using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6v7
{
    public static class StaticHelpers
    {
        public static double GetPercentage(int areaOfPiece, int areaOfWhole)
        {
            return ((double) areaOfPiece) / areaOfWhole * 100;
        }
    }
}
