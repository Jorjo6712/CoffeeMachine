namespace ConsoleApp1.Model;
using Interfaces;
public class BeanGrinder : IBeanGrinder
{
    public void GrindBeans()
    {
        Console.WriteLine("Grinding beans...");
    }
}
