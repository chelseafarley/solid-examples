using System;
namespace SolidPrinciples
{
    public class GrossPayCalculator : IPayCalculator
    {
        public decimal HourlyRate { get; set; }

        public GrossPayCalculator(decimal hourlyRate)
        {
            HourlyRate = hourlyRate;
        }

        public decimal Calculate(decimal hours)
        {
            return HourlyRate * hours;
        }
    }
}

