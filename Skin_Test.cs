using System;

class SkinTestMonitor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Skin Test Monitor!");

        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Perform skin test for hazardous materials");
            Console.WriteLine("2. Perform skin test for non-hazardous materials");
            Console.WriteLine("3. Test foreign products that touch the skin");
            Console.WriteLine("4. Exit");

            int choice = GetValidIntegerInput("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    PerformHazardousSkinTest();
                    break;
                case 2:
                    PerformNonHazardousSkinTest();
                    break;
                case 3:
                    TestForeignProducts();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Skin Test Monitor. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void PerformHazardousSkinTest()
    {
        Console.WriteLine("Performing skin test for hazardous materials...");
        Console.WriteLine("Please consult a healthcare professional for proper procedures.");
    }

    static void PerformNonHazardousSkinTest()
    {
        Console.WriteLine("Performing skin test for non-hazardous materials...");
        Console.WriteLine("Ensure the material is safe for skin contact and conduct a patch test if necessary.");
    }

    static void TestForeignProducts()
    {
        Console.WriteLine("Testing foreign products that touch the skin...");
        Console.WriteLine("Ensure the product is free from allergens
