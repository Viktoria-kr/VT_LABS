using OOP_COLLECTIONS;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Department itDepartment = new Department("IT");

        Worker worker1 = new Worker("Анна Петрова", 30000, 22);
        Worker worker2 = new Worker("Иван Сидоров", 28000, 18);

        Programmer programmer1 = new Programmer("Екатерина Смирнова", 50000, Level.Middle);
        Programmer programmer2 = new Programmer("Дмитрий Козлов", 70000, Level.Senior);

        Manager manager = new Manager("Ольга Новикова", 60000, 8);

        Console.WriteLine("--- Добавление сотрудников в отдел ---");
        itDepartment.AddEmployee(worker1);
        itDepartment.AddEmployee(worker2);
        itDepartment.AddEmployee(programmer1);
        itDepartment.AddEmployee(programmer2);
        itDepartment.AddEmployee(manager);

        Console.WriteLine("\n=== Все сотрудники отдела ===");
        itDepartment.ShowAllEmployees();

        Console.WriteLine("\n=== Тестируем поиск сотрудника ===");
        FindAndDisplayEmployee(itDepartment, 1);
        FindAndDisplayEmployee(itDepartment, 3);
        FindAndDisplayEmployee(itDepartment, 7);

        Console.WriteLine("\n=== Тестируем удаление сотрудника ===");
        itDepartment.RemoveEmployeeById(2);

        Console.WriteLine("\n=== После удаления ===");
        itDepartment.ShowAllEmployees();

        Console.WriteLine("\n=== Статистика Отдела ===");
        itDepartment.GetDepartmentInfo();
    }

    static void FindAndDisplayEmployee(Department dept, int id)
    {
        Employee? emp = dept.FindEmployeeById(id);
        if (emp != null)
        {
            Console.WriteLine($"\nНайден сотрудник с ID {id}:");
            emp.DisplayInfo();
        }
        else
        {
            Console.WriteLine($"Сотрудник с ID {id} не найден.");
        }
    }
}