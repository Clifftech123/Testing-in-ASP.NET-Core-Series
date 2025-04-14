

using AspNetCore_Testing_Part2_UnitTesting;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🧪 STARTING UNIT TESTS");
        Console.WriteLine("======================\n");


        // Create and run the tests
        var calculatorTests = new AddingNumberAndReturnItTests();
        calculatorTests.RunTests();

        Console.WriteLine("\n🏁 TESTING COMPLETE");
        Console.WriteLine("===================");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();

    }
}