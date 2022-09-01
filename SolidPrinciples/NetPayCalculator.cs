namespace SolidPrinciples;

public class NetPayCalculator : IPayCalculator
{
    public decimal HourlyRate { get; set; }
    public decimal TaxRate { get; set; }

    public NetPayCalculator(decimal hourlyRate, decimal taxRate)
    {
        HourlyRate = hourlyRate;
        TaxRate = taxRate;
    }

    public decimal Calculate(decimal hours)
    {
        return (1 - TaxRate) * hours * HourlyRate;
    }
}

