namespace ConsoleApp1.Controllers;
using Model;
using Model.Interfaces;

public class CoffeeMachine : ICoffeeMachine
{
    private readonly IHeater heater;
    private readonly IFilter filter;
    private readonly IBeanGrinder beanGrinder;
    private readonly IWaterTank waterTank;
    private readonly Coffee coffee;

    public CoffeeMachine(IHeater heater, IFilter filter, IBeanGrinder beanGrinder, IWaterTank waterTank, Coffee coffee)
    {
        this.heater = heater;
        this.filter = filter;
        this.beanGrinder = beanGrinder;
        this.waterTank = waterTank;
        this.coffee = coffee;
    }

    public void MakeCoffee()
    {
        waterTank.FillWater();
        beanGrinder.GrindBeans();
        heater.HeatWater();
        filter.FilterCoffee();
        coffee.Brew();
        Console.WriteLine($"{coffee} is ready!");
    }
}
