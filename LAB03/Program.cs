namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Задание 1.1 ===");
            Rational r1 = new Rational();
            Rational r2 = new Rational(5);
            Rational r3 = new Rational(6, 8);
            Rational r4 = new Rational(-3, -6);
            Rational r5 = new Rational(2, -4);
            Console.WriteLine($"r1 = {r1}");
            Console.WriteLine($"r2 = {r2}");
            Console.WriteLine($"r3 = {r3}");
            Console.WriteLine($"r4 = {r4}");
            Console.WriteLine($"r5 = {r5}");

            Console.WriteLine("\n=== Задание 1.2 ===");
            Rational r6 = new Rational(12, 18);
            Console.WriteLine($"12/18 после сокращения: {r6}");
            r6.Numerator = 100;
            r6.Denominator = 250;
            r6.Reduce();
            Console.WriteLine($"100/250 после Reduce(): {r6}");

            Console.WriteLine("\n=== Задание 1.3 ===");
            Console.WriteLine($"(-3)/(-6) нормализовано: {r4}");
            Console.WriteLine($"2/(-4) нормализовано: {r5}");

            Console.WriteLine("\n=== Задание 1.4 ===");
            Rational a = new Rational(1, 2);
            Rational b = new Rational(1, 3);
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");

            Console.WriteLine("\n=== Задание 2.1 ===");
            Rational x = new Rational(2, 4);
            Rational y = new Rational(1, 2);
            Rational z = new Rational(3, 6);
            Console.WriteLine($"{x} == {y} : {x == y}");
            Console.WriteLine($"{x} != {y} : {x != y}");
            Console.WriteLine($"{x} == {z} : {x == z}");

            Console.WriteLine("\n=== Задание 2.2 ===");
            Console.WriteLine($"{x}.Equals({y}) : {x.Equals(y)}");
            Console.WriteLine($"{x}.Equals(null) : {x.Equals(null)}");
            Console.WriteLine($"{x}.Equals(\"строка\") : {x.Equals("строка")}");

            Console.WriteLine("\n=== Задание 3.1 ===");
            Rational zero = new Rational(0, 5);
            Rational neg = new Rational(-3, 4);
            Console.WriteLine($"Ноль: {zero}");
            Console.WriteLine($"Отрицательная дробь: {neg}");
            Console.WriteLine($"{neg} + {a} = {neg + a}");
            Console.WriteLine($"{neg} * {zero} = {neg * zero}");

            Console.WriteLine("\n=== Задание 3.2 ===");
            try
            {
                Rational divByZero = a / new Rational(0, 1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            try
            {
                Rational bad = new Rational(1, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка создания: {ex.Message}");
            }
        }
    }
}