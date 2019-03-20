using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee
    {
        public Employee(string firstName, string lastName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public DateTime StartDate { get; set; }

    }

    public class Company
    {
        public Company(string name, DateTime dateFounded) {
            Name = name;
            DateFounded = dateFounded;
        }
        public DateTime DateFounded { get; }
        public string Name { get; }
        public List<Employee> Employees { get; set; }

        public void ListEmployees () {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FullName} works for {this.Name} as {employee.Title}.");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Company NSS = new Company("Nashville Software School", DateTime.Now);

            Employee elyse = new Employee("Elyse", "Dawson", "TA");
            Employee joe = new Employee("Joe", "Shepherd", "Instructor");
            Employee john = new Employee("John", "Wark", "Founder");

            List<Employee> employees = new List<Employee>();

            employees.Add(elyse);
            employees.Add(joe);
            employees.Add(john);
            NSS.Employees = employees;
            NSS.ListEmployees();

        }
    }
}
