namespace ConsoleApp1.Model;
using Interfaces;
public class WaterTank : IWaterTank
{
    private int waterLevel;

    public void FillWater()
    {
        waterLevel = 100; // Assume 100 is full
        Console.WriteLine("Filling water tank...");
    }

    public void UseWater(int amount)
    {
        if (waterLevel >= amount)
        {
            waterLevel -= amount;
            Console.WriteLine($"Using {amount} units of water...");
        }
        else
        {
            Console.WriteLine("Not enough water!");
        }
    }
}
