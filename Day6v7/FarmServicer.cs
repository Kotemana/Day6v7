using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6v7
{
    public class FarmService
    {
        public void AddGardenbed(Farm farm, Gardenbed gardenbed)
        {
            var areaAfter = farm.Gardenbeds.Sum(x => x.Area) + gardenbed.Area;
            var percentAfter = StaticHelpers.GetPercentage(areaAfter, farm.Area);
            if(percentAfter <= 100)
            {
                farm.Gardenbeds.Add(gardenbed);
                Console.WriteLine($"Gardenbed successfully added, now farm is filled at {percentAfter}%");

            }
            else
            {
                Console.WriteLine("Not enough Area, go to naher");
            }
        }

        public void AddPlant(Gardenbed gardenbed, Plant plant)
        {
            var areaAfter = gardenbed.Plants.Sum(x => x.Area) + plant.Area;
            var percentAfter = StaticHelpers.GetPercentage(areaAfter, gardenbed.Area);
            if (percentAfter <= 100)
            {
                gardenbed.Plants.Add(plant);
                Console.WriteLine($"Plant successfully added, now gardenbed is filled at {percentAfter}%");

            }
            else
            {
                Console.WriteLine("Not enough Area, go to naher");
            }

        }
    }
}
