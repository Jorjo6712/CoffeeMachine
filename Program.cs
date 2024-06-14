namespace ConsoleApp1;
using ConsoleApp1.Model;
using ConsoleApp1.Controllers;
using ConsoleApp1.Model.Interfaces;

public class Program
{
    static void Main()
    {
        IBeanGrinder beanGrinder = new BeanGrinder();
        IFilter filter = new Filter();
        IHeater heater = new Heater();
        IWaterTank waterTank = new WaterTank();
        Coffee coffee = new Espresso();
        
        ICoffeeMachineController coffeeMachineController = new CoffeeMachineController(heater, filter, beanGrinder, waterTank, coffee);
        coffeeMachineController.StartMachine();
    }
}