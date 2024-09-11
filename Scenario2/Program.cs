using System;
using System.Collections.Generic;

namespace Scenario2
{
    public class Employee
    {
        
        private string name;
        private string eid;
        private double salary;
        private string joinDate;

        
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public string Eid
        {
            get { return eid; }
            protected set { eid = value; }
        }

        public double Salary
        {
            get { return salary; }
            protected set { salary = value; }
        }

        public string JoinDate
        {
            get { return joinDate; }
            protected set { joinDate = value; }
        }

        
        public Employee(string id, string name, double salary, string joinDate)
        {
            Name = name;
            Eid = id;
            Salary = salary;
            JoinDate = joinDate;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"ID: {Eid}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Joining Date: {JoinDate}");
        }

        public virtual double GrossIncome()
        {
            return 12 * Salary;
        }
    }

    public class FullTime : Employee
    {
        // Property for FullTimeEmployee
        public double Bonus { get; private set; }

        public FullTime(string id, string name, double salary, string joinDate, double bonus)
            : base(id, name, salary, joinDate)
        {
            Bonus = bonus;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Bonus: {Bonus:C}");
        }

        public override double GrossIncome()
        {
            return (12 * Salary) + (2 * Bonus);
        }
    }

    public class PartTime : Employee
    {
        
        public double Commission { get; private set; }

        public PartTime(string id, string name, double salary, string joinDate, double commission)
            : base(id, name, salary, joinDate)
        {
            Commission = commission;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Commission: {Commission:C}");
        }

        public override double GrossIncome()
        {
            return (12 * Salary) + Commission;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new FullTime("1", "John Doe", 3000, "2020-01-15", 1500),
                new PartTime("2", "Jane Smith", 1500, "2021-03-22", 500)
            };

            foreach (var employee in employees)
            {
                employee.ShowInfo();
                Console.WriteLine($"Gross Income: {employee.GrossIncome():C}");
                Console.WriteLine();
            }
        }
    }
}
