namespace ConsoleApp1.Model;
using Interfaces;
public class Heater : IHeater
{
    public void HeatWater()
    {
        Console.WriteLine("Heating water...");
    }
}
