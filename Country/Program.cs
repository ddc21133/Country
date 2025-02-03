using System;

using System.Collections.Generic;

 

class Program

{


    // Name: Dorien Carter

    // Course: CIS261

    // Lab: Country

 

    static void Main(string[] args)

    {

        // Initialize the dictionary with countries

        var countries = InitializeCountries();

 

        while (true)

        {

            // Display the menu to the user

            DisplayMenu();

 

            // Read the user's choice

            string choice = Console.ReadLine();

 

            // Handle menu choices

            switch (choice)

            {

                case "1":

                    ViewCountries(countries);

                    break;

                case "2":

                    AddCountry(countries);

                    break;

                case "3":

                    DeleteCountry(countries);

                    break;

                case "4":

                    Console.WriteLine("Exiting program. Goodbye!");

                    Environment.Exit(0);

                    break;

                default:

                    Console.WriteLine("Invalid choice. Please try again.");

                    break;

            }

        }

    }

 

    // Part 1: Function to display the menu

    static void DisplayMenu()

    {

        Console.WriteLine("\nCountry Dictionary Menu:");

        Console.WriteLine("1. View all countries");

        Console.WriteLine("2. Add a country");

        Console.WriteLine("3. Delete a country");

        Console.WriteLine("4. Exit");

        Console.Write("Choose an option: ");

    }

 

    // Part 2: Function to prepopulate the dictionary

    static Dictionary<string, string> InitializeCountries()

    {

        return new Dictionary<string, string>

        {

            { "US", "United States" },

            { "CA", "Canada" },

            { "MX", "Mexico" }

        };

    }

 

    // Part 3: Function to view countries

    static void ViewCountries(Dictionary<string, string> countries)

    {

        Console.WriteLine("\nCurrent countries in the dictionary:");

        foreach (var country in countries)

        {

            Console.WriteLine($"{country.Key}: {country.Value}");

        }

 

        Console.Write("\nEnter a country code to view details: ");

        string code = Console.ReadLine();

        if (countries.ContainsKey(code))

        {

            Console.WriteLine($"Country: {countries[code]}");

        }

        else

        {

            Console.WriteLine("Invalid country code.");

        }

    }

 

    // Part 3: Function to add a country

    static void AddCountry(Dictionary<string, string> countries)

    {

        Console.Write("\nEnter country code: ");

        string code = Console.ReadLine();

        Console.Write("Enter country name: ");

        string name = Console.ReadLine();

 

        if (!countries.ContainsKey(code))

        {

            countries[code] = name;

            Console.WriteLine("Country added successfully.");

        }

        else

        {

            Console.WriteLine("Country code already exists. Please try a different code.");

        }

    }

 

    // Part 3: Function to delete a country

    static void DeleteCountry(Dictionary<string, string> countries)

    {

        Console.Write("\nEnter country code to delete: ");

        string code = Console.ReadLine();

 

        if (countries.Remove(code))

        {

            Console.WriteLine("Country deleted successfully.");

        }

        else

        {

            Console.WriteLine("Invalid country code. No country was deleted.");

        }

    }

}
