using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Divya", Gender = "Female", Department = "CSE", Salary = 35000},
                new Employee() {Id = 2, Name = "kavya", Gender = "Female", Department = "IT", Salary = 35000},
                new Employee() {Id = 3, Name = "sravya", Gender = "Female", Department = "CSE", Salary = 35000},
                new Employee() {Id = 4, Name = "Navya", Gender = "Female", Department = "CSE", Salary = 35000},
                new Employee() {Id = 5, Name = "Bhavya", Gender = "Female", Department = "CSE", Salary = 35000},
                new Employee() {Id = 6, Name = "vidhya", Gender = "Female", Department = "IT", Salary = 35000},
                new Employee() {Id = 7, Name = "Soumya", Gender = "Female", Department = "CSE", Salary = 35000},
                new Employee() {Id = 8, Name = "ramya", Gender = "Female", Department = "IT", Salary = 35000},
                new Employee() {Id = 9, Name = "Ajay", Gender = "Male", Department = "IT", Salary = 35000},
                new Employee() {Id = 10, Name = "Srikath", Gender = "Male", Department = "CSE", Salary = 35000},
            };
            return employees;
        }
    }
}
