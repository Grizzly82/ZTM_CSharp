// See https://aka.ms/new-console-template for more information


// Create a list of buildings
List<Building> realEstateBuildings = new List<Building>
        {
            new Building { Size = 2500, TaxPerSize = 5.75, Name = "Downtown Tower" },
            new Building { Size = 1800, TaxPerSize = 4.25, Name = "Riverfront Plaza" },
            new Building { Size = 3500, TaxPerSize = 8.50, Name = "Luxury Heights Tower"},
            new Building { Size = 2200, TaxPerSize = 6.75, Name = "Green Meadows Apartments"},
            new Building { Size = 2800, TaxPerSize = 7.90, Name = "Riverside Villas"},
            new Building { Size = 4000, TaxPerSize = 9.25, Name = "Skyline Plaza Offices"}
            // Add more buildings here...
        };

// Print information about each building
Console.WriteLine("Real Estate Buildings:");
foreach (var building in realEstateBuildings)
{
    Console.WriteLine($"Name: {building.Name}, Size: {building.Size} sqft, Tax/Size: ${building.TaxPerSize}");
}

// Calculate the total estimated tax using LINQ
double totalTax = realEstateBuildings.Sum(building => building.Size * building.TaxPerSize);

Console.WriteLine($"Total estimated tax for all buildings: ${totalTax}");


// Filter buildings with a size greater than 2000 sqft
var largeBuildings = from building in realEstateBuildings
                     where building.Size > 2000
                     select building;

// Print the filtered buildings
Console.WriteLine("Large Buildings:");
foreach (var building in largeBuildings)
{
    Console.WriteLine($"Name: {building.Name}, Size: {building.Size} sqft");
}

public class Building
{
    public double Size { get; set; } // Size in square feet or meters
    public double TaxPerSize { get; set; } // Tax amount per unit of size
    public string Name { get; set; } // Name of the building

    // Additional properties or methods can be added here
}


