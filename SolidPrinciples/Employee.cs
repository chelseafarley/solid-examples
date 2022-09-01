namespace SolidPrinciples;

public class Employee : Person
{
    public string EmployeeCode { get; set; }
    public decimal HourlyRate { get; set; }
    public decimal TaxRate { get; set; }
    public IPayCalculator PayCalculator { get; set; }

    public Employee(string name, string employeeCode, decimal hourlyRate, decimal taxRate, IPayCalculator payCalculator) : base(name)
    {
        EmployeeCode = employeeCode;
        HourlyRate = hourlyRate;
        TaxRate = taxRate;
        PayCalculator = payCalculator;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()} Employee Code: {EmployeeCode}. Hourly Rate: {HourlyRate}. Tax Rate: {TaxRate}.";  
    }

    public decimal CalculatePay(decimal hours)
    {
        return PayCalculator.Calculate(hours);
    }
}

