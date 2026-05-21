namespace OOP_COLLECTIONS
{
    public class Worker : Employee
    {
        public int MonthlyShifts { get; set; }

        public Worker(string name, double baseSalary, int monthlyShifts)
            : base(name, baseSalary)
        {
            MonthlyShifts = monthlyShifts;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is doing shift-based work.");
        }

        public override double CalculateSalary()
        {
            double bonus = 0;
            if (MonthlyShifts > 20)
            {
                bonus = (MonthlyShifts - 20) * 50;
            }
            return BaseSalary + bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Monthly Shifts: {MonthlyShifts}");
        }
    }
}