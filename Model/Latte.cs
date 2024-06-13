namespace ConsoleApp1.Model;

public class Latte : Coffee
{
    public override void Brew()
    {
        Console.WriteLine("Brewing Latte...");
    }
}