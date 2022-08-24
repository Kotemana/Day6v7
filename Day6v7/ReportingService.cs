using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6v7
{
    public class ReportingService
    {
        public void FarmReport(Farm farm)
        {
            Console.WriteLine($"{farm.Name} has an area of {farm.Area} and it has {farm.Gardenbeds.Count} gardenbeds");
            Console.WriteLine($"Farm is filled at {StaticHelpers.GetPercentage(farm.Gardenbeds.Sum(x => x.Area), farm.Area)}%");

        }

        public void GardenbedReport(Farm farm)
        {
            foreach (var bed in farm.Gardenbeds)
            {
                Console.WriteLine("This Gardenbed has:");
                foreach (var plant in bed.Plants)
                {
                    Console.WriteLine($"{plant.Name} takes {plant.Area} area");
                }
                Console.WriteLine($"Gardenbed is filled at {StaticHelpers.GetPercentage(bed.Plants.Sum(x => x.Area), bed.Area)}%");
            }
        }

        

    }
}
