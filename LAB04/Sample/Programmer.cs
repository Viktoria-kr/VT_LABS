namespace OOP_COLLECTIONS
{
    public enum Level
    {
        Junior,
        Middle,
        Senior,
        Lead
    }

    public class Programmer : Employee
    {
        public Level Level { get; set; }

        public Programmer(string name, double baseSalary, Level level)
            : base(name, baseSalary)
        {
            Level = level;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working as a {Level} developer.");
        }

        public override double CalculateSalary()
        {
            double bonus = 0;
            switch (Level)
            {
                case Level.Junior:
                    bonus = 300;
                    break;
                case Level.Middle:
                    bonus = 600;
                    break;
                case Level.Senior:
                    bonus = 1000;
                    break;
                case Level.Lead:
                    bonus = 1500;
                    break;
            }
            return BaseSalary + bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Level: {Level}");
        }
    }
}