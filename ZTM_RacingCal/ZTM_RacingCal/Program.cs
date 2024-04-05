// See https://aka.ms/new-console-template for more information




using System;
using System.Collections.Generic;

List<Race> racingCalendar = new List<Race>
        {
            new Race { RaceName = "Monaco Grand Prix", RaceDate = new DateTime(2024, 05, 26), TrackName = "Circuit de Monaco" },
            new Race { RaceName = "Le Mans 24 Hours", RaceDate = new DateTime(2024, 06, 15), TrackName = "Circuit de la Sarthe" },
            new Race { RaceName = "Indy 500", RaceDate = new DateTime(2024, 05, 26), TrackName = "Indianapolis Motor Speedway" }
            // Add more races here...
        };


Race formula1Race = new Race();

// Create some drivers
Driver lewisHamilton = new Driver { DriverName = "Lewis Hamilton" };
Driver maxVerstappen = new Driver { DriverName = "Max Verstappen" };
Driver sergioPerez = new Driver { DriverName = "Sergio Perez" };

// Add drivers to the race
formula1Race.AddDriver(lewisHamilton);
formula1Race.AddDriver(maxVerstappen);
formula1Race.AddDriver(sergioPerez);

// Try adding more drivers (up to 20)
// ...


Queue<Driver> waitingList = new Queue<Driver>();

// Add drivers to the waiting list
waitingList.Enqueue(new Driver { DriverName = "Lewis Hamilton" });
waitingList.Enqueue(new Driver { DriverName = "Max Verstappen" });
waitingList.Enqueue(new Driver { DriverName = "Sergio Perez" });


// Add more drivers to the waiting list
// ...

// Take the next driver from the list
if (waitingList.Count > 0)
{
    var nextDriver = waitingList.Dequeue();
    Console.WriteLine($"Next driver: {nextDriver.DriverName}");
}
else
{
    Console.WriteLine("No drivers in the waiting list.");
}
// Print the final list of drivers
Queue<Driver> _ = new Queue<Driver>();

// Add drivers to the waiting list
waitingList.Enqueue(new Driver { DriverName = "Lewis Hamilton" });
waitingList.Enqueue(new Driver { DriverName = "Max Verstappen" });
waitingList.Enqueue(new Driver { DriverName = "Sergio Perez" });

// Add more drivers to the waiting list
// ...

// Take the next driver from the list
if (waitingList.Count > 0)
{
    var nextDriver = waitingList.Dequeue();
    Console.WriteLine($"Next driver: {nextDriver.DriverName}");
}
else
{
    Console.WriteLine("No drivers in the waiting list.");
}

Console.WriteLine("Racing Calendar:");
foreach (var race in racingCalendar)
{
    Console.WriteLine(race);
}


public class Race
{
    public string RaceName { get; set; }
    public DateTime RaceDate { get; set; }
    public string TrackName { get; set; }

    public override string ToString()
    {
        return $"{RaceName} ({RaceDate:yyyy-MM-dd}) at {TrackName}";
    }

    private const int MaxDrivers = 20;
    private readonly List<Driver> drivers = new List<Driver>();

    public void AddDriver(Driver driver)
    {
        if (drivers.Count < MaxDrivers)
        {
            drivers.Add(driver);
            Console.WriteLine($"Driver {driver.DriverName} added to the race.");
        }
        else
        {
            Console.WriteLine("Starting grid is full. Cannot add more drivers.");
        }
    }

}


public class Driver
{
    public string DriverName { get; set; }
}


