using SolidPrinciples;

Console.WriteLine(new Person("Jane Doe").GetInfo());
GrossPayCalculator gpc1 = new GrossPayCalculator(24.34m);
Console.WriteLine(new Employee("Terry Watts", "TW11", 24.34m, 0.25m, gpc1).GetInfo());

GrossPayCalculator gpc2 = new GrossPayCalculator(27.6m);
Person aPerson = new Employee("Joe Black", "JB123", 27.6m, 0.25m, gpc2);
Console.WriteLine(aPerson.GetInfo());

GrossPayCalculator gpc3 = new GrossPayCalculator(22.2m);
NetPayCalculator npc = new NetPayCalculator(22.2m, 0.2m);

Console.WriteLine("Which calculator would you like to use? N for Net Pay, G for Gross Pay:");
string calculatorPreference = Console.ReadLine();

Employee ab = new Employee("Annie Bates", "AB1", 22.2m, 0.2m, calculatorPreference == "N" ? npc : gpc3);
Console.WriteLine(ab.CalculatePay(2.5m));

GrossPayCalculator gpc4 = new GrossPayCalculator(12.5m);
INonRemoteEmployee bc = new NonRemoteEmployee("Beryl Chamberland", "BC222", 12.5m, 0.1m, gpc4);
bc.TransitToWork();

GrossPayCalculator gpc5 = new GrossPayCalculator(12.5m);
INonRemoteEmployee jc = new DeliveryDriverEmployee("James Courage", "JC212", 12.5m, 0.1m, gpc5);
jc.TransitToWork();

