using System;
using EmployeeManagement;

class Program
{
    static void Main()
    {
        EmployeeManager manager = new EmployeeManager();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("💼 Employee Management System 💼");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.AddEmployee();
                    break;
                case "2":
                    manager.ViewEmployees();
                    break;
                case "3":
                    manager.SearchEmployee();
                    break;
                case "4":
                    manager.DeleteEmployee();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
