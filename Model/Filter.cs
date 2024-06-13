namespace ConsoleApp1.Model;
using Interfaces;
public class Filter : IFilter
{
    public void FilterCoffee()
    {
        Console.WriteLine("Filtering coffee...");
    }
}