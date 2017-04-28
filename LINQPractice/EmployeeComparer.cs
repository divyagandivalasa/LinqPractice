using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class EmployeeComparer :IEqualityComparer<Emp>
    {
        public bool Equals(Emp x, Emp y)
        {
            return x.EmployeeId == y.EmployeeId && x.EmployeeName == y.EmployeeName && x.DepartmentId == y.DepartmentId;
        }

        public int GetHashCode(Emp obj)
        {
            return obj.EmployeeId.GetHashCode() ^ obj.EmployeeName.GetHashCode() ^ obj.DepartmentId.GetHashCode();
        }
    }
}
