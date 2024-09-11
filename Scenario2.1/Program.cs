using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario2._1
{
    public class Employee
    {    
        String id;
        String name;
        double salary;
        String joinDate;
        public Employee(String id, String name, double salary, String joinDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joinDate = joinDate;
        }
        
        public double getSalary() 
        {
            return salary;
        }
        public String getName() 
        {
            return name;
        }
        public String getId()
        {
            return id;
        }
        public String getJoinDate() 
        {
            return joinDate;
        }
    }

    public class FullTime : Employee 
    {
        double bonus;
        double grossincome;
        
        public FullTime(String id, String name, double salary, String joinDate, double bonus) : base( id, name,salary, joinDate)  
        {
            this.bonus = bonus;
        }
   
        public void ShowInfo()
        {
            Console.WriteLine(" Name: " + base.getName());
            Console.WriteLine(" Id: " + base.getId());
            Console.WriteLine(" Salary: " + base.getSalary());
            Console.WriteLine("Joining date: " + base.getJoinDate());
        }
        
        public void GrossIncome()
        {
            grossincome = base.getSalary() * 12 + bonus * 2;   
            Console.WriteLine("Gross Income: " + grossincome);
        }
    }

    public class PartTime : Employee  
    {
        
        double commission;
        double grossincome;

        public PartTime(String id, String name, double salary, String joinDate, double commission) : base(id, name, salary, joinDate) 
        {
            this.commission = commission;
        }
        //parameterized constructor to initialize properties
        public void ShowInfo()
        {
            
            Console.WriteLine("Employee name: " + base.getName());
            Console.WriteLine("Employee id: " + base.getId());
            Console.WriteLine("Employee salary: " + base.getSalary());
            Console.WriteLine("Employee joining date:  " + base.getJoinDate());
        }
        //compute the gross income
        public void GrossIncome()
        {
            grossincome = base.getSalary() * 12 + commission; 
            Console.WriteLine("Gross Income: " + grossincome);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTime fulltime = new FullTime("11255-8", "Khalid", 58000, "18-11-2019", 5000);  
            PartTime parttime = new PartTime("84855-66", "Rayhan", 88000, "27-09-2022", 2300); 
            fulltime.ShowInfo(); 
            fulltime.GrossIncome(); 
            parttime.ShowInfo();
            parttime.GrossIncome();
        }
    }
}
