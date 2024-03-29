// See https://aka.ms/new-console-template for more information
/****************************************************************
 * Implement a HowOld method that returns how long the building already exists
 *  x = current year - year built
 *  Write a method CanBeSold that checks whether the building is older than 15 years
 *  and returns a boolean value
 *  Use the HowOld method implemented in the previous step
 *  Use access modifiers and turn the HowOld method into a private method only used
 *   within the CanBeSold method. Remove code that does not compile.
 *   
 *   
 *   
 *****************************************************************/


using System;

namespace RealEstate
{
    class House
    {
        // Properties
        public int YearBuilt { get; }
        public string Size { get; }

        // Constructor
        public House(int yearBuilt, string size)
        {
            YearBuilt = yearBuilt;
            Size = size;
        }

        // Calculate the age of the house (private method)
        private int CalculateAge()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - YearBuilt;
        }

        // Check if the building can be sold (public method)
        public bool CanBeSold()
        {
            int age = CalculateAge();
            return age > 15;
        }

        // Example usage
        static void Main(string[] args)
        {
            // Create an instance of the House class
            House myHouse = new House(yearBuilt: 1990, size: "1500 sq ft");

            // Display the house details
            Console.WriteLine($"My house was built in {myHouse.YearBuilt} and has a size of {myHouse.Size}.");
            Console.WriteLine($"It is {myHouse.CalculateAge()} years old.");

            // Check if the house can be sold
            bool canBeSold = myHouse.CanBeSold();
            Console.WriteLine($"Can the house be sold? {canBeSold}");
        }
    }
}
