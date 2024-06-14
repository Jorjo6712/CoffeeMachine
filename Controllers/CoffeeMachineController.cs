namespace ConsoleApp1.Controllers;
using Model;
using Model.Interfaces;
public class CoffeeMachineController : ICoffeeMachineController
{
    
    private readonly IHeater heater;
    private readonly IFilter filter;
    private readonly IBeanGrinder beanGrinder;
    private readonly IWaterTank waterTank;
    private Coffee coffee;
    
    private readonly ICoffeeMachine coffeeMachine;

    public CoffeeMachineController(IHeater heater, IFilter filter, IBeanGrinder beanGrinder, IWaterTank waterTank, Coffee coffee)
    {
        this.heater = heater;
        this.filter = filter;
        this.beanGrinder = beanGrinder;
        this.waterTank = waterTank;
        this.coffee = coffee;
        coffeeMachine = new CoffeeMachine(heater, filter, beanGrinder, waterTank, coffee);
    }
    public void StartMachine()
    {
       coffeeMachine.MakeCoffee();
    }
}