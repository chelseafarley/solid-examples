namespace SolidPrinciples;

public class DeliveryDriverEmployee : Employee, INonRemoteEmployee
{
    public DeliveryDriverEmployee(string name, string employeeCode, decimal hourlyRate, decimal taxRate, IPayCalculator payCalculator)
        : base(name, employeeCode, hourlyRate, taxRate, payCalculator)
    {
    }

    public void TransitToWork()
    {
        Console.WriteLine("Delivering items, yay!");
    }
}

