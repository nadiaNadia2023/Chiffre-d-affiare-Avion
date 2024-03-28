using NUnit.Framework;
using Project.Classes;

class Program
{
    static void Main()
    {
        AirplaneTicketing ticketing = new AirplaneTicketing();
        ticketing.GeneratePassengersAndFamilies();
        ticketing.OptimizeRevenue();
        Console.ReadKey(true);
    
    }


       
}
