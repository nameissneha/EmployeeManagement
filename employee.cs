namespace EmployeeManagement
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Age}, {Salary:C}, {Department}";
        }
    }
}
