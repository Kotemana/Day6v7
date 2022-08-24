using Day6v7;
var farm = new Farm() { Name = "Super Farm", Area = 1000};
var service = new FarmService();
var beetroot = new Plant() { Name = "Beetroot", Area = 5, HarvestSeason = Season.autumn, PlantSeason = Season.spring };
var pumpkin = new Plant() { Name = "Pumpkin", Area = 25, HarvestSeason = Season.autumn, PlantSeason = Season.summer };
var gardenbed = new Gardenbed() { Area = 100 };
service.AddPlant(gardenbed, beetroot);
service.AddPlant(gardenbed, pumpkin);
service.AddGardenbed(farm, gardenbed);
var reporting = new ReportingService();
reporting.FarmReport(farm);
reporting.GardenbedReport(farm);
var bigGardenbed = new Gardenbed() { Area = 999 };
service.AddGardenbed(farm, bigGardenbed);
Console.WriteLine("select a season");
foreach (Season season in (Season[])Enum.GetValues(typeof(Season)))
{
    Console.WriteLine($"{(int)season} - {season}");
}

Season response = (Season) int.Parse(Console.ReadLine());

Console.WriteLine($"You selected {response}");