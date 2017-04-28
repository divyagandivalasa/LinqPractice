using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class Emp
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }

        public static List<Emp> GetAllEmployees()
        {
            List<Emp> employees = new List<Emp>()
            {
                new Emp() {EmployeeId = 1, EmployeeName = "Divya", DepartmentId = 1},
                new Emp() {EmployeeId = 1, EmployeeName = "Divya", DepartmentId = 1},
                new Emp() {EmployeeId = 2, EmployeeName = "kavya", DepartmentId = 2},
                new Emp() {EmployeeId = 3, EmployeeName = "Navya", DepartmentId = 1},
                new Emp() {EmployeeId = 4, EmployeeName = "Bhavya", DepartmentId = 1},
                new Emp() {EmployeeId = 5, EmployeeName = "Ramya", DepartmentId = 2},
                new Emp() {EmployeeId = 6, EmployeeName = "Sravya", DepartmentId = 2},
                new Emp() {EmployeeId = 7, EmployeeName = "Vidhya"},
            };
            return employees;
        }

        //public override bool Equals(object obj)
        //{
        //    return this.EmployeeId == ((Emp) obj).EmployeeId && this.EmployeeName == ((Emp) obj).EmployeeName &&
        //           this.DepartmentId == ((Emp) obj).DepartmentId;
        //}

        //public override int GetHashCode()
        //{
        //    return this.EmployeeId.GetHashCode() ^ this.EmployeeName.GetHashCode() ^ this.DepartmentId.GetHashCode();
        //}
    }
}
