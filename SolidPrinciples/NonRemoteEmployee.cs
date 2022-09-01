namespace SolidPrinciples;

public class NonRemoteEmployee : Employee, INonRemoteEmployee
{
    public NonRemoteEmployee(string name, string employeeCode, decimal hourlyRate, decimal taxRate, IPayCalculator payCalculator)
        : base(name, employeeCode, hourlyRate, taxRate, payCalculator)
    {
    }

    public void TransitToWork()
    {
        Console.WriteLine("Heigh-ho, heigh-ho. It's off to work we go...");
    }
}

