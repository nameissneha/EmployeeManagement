using EmployeeManagement;

namespace EmployeeManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();
        private const string filePath = "employees.csv";

        public EmployeeManager() { LoadEmployeesFromFile(); }

        public void AddEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            employees.Add(new Employee { ID = id, Name = name, Age = age, Salary = salary, Department = department });
            Console.WriteLine("✅ Employee added successfully!");
        }

        public void ViewEmployees()
        {
            Console.WriteLine("\n📋 Employee List:");
            foreach (var emp in employees) { Console.WriteLine(emp); }
        }

        public void SearchEmployee()
        {
            Console.Write("Enter Employee ID to search: ");
            int id = int.Parse(Console.ReadLine());
            var emp = employees.Find(e => e.ID == id);

            if (emp != null) { Console.WriteLine("\n🔍 Employee Found:\n" + emp); }
            else { Console.WriteLine("❌ Employee not found."); }
        }

        public void DeleteEmployee()
        {
            Console.Write("Enter Employee ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            var emp = employees.Find(e => e.ID == id);

            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("🗑️ Employee deleted successfully!");
            }
            else { Console.WriteLine("❌ Employee not found."); }
        }

        private void LoadEmployeesFromFile()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        employees.Add(new Employee
                        {
                            ID = int.Parse(data[0]),
                            Name = data[1],
                            Age = int.Parse(data[2]),
                            Salary = double.Parse(data[3]),
                            Department = data[4]
                        });
                    }
                }
                Console.WriteLine("📂 Employee data loaded successfully!");
            }
        }
    }
}
