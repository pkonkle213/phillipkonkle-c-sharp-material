namespace Exercises.Classes
{
    public class Employee
    {
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }
        
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public double AnnualSalary { get; private set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public void RaiseSalary(double percent)
        {
            AnnualSalary *= 1 + percent / 100.0;
        }
    }
}
