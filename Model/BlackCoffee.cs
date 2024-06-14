namespace ConsoleApp1.Model;

public class BlackCoffee : Coffee
{
    public override void Brew()
    {
        Console.WriteLine("Brewing Black Coffee...");
    }
    
    public override string ToString()
    {
        return "Black Coffee";
    }
}