using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6v7
{
    public class Farm
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public List<Gardenbed> Gardenbeds { get; set; } = new List<Gardenbed>();

    }
}
