using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Select             

            //Select

            //IEnumerable<string> s = Student.GetAllStudents().Select(x => x.Name);
            //foreach (var val in s)
            //{
            //    Console.WriteLine(val);
            //}
            //var s = Student.GetAllStudents().Select(x => new {Name = x.Name, Gender = x.Gender});
            //foreach (var val in s)
            //{
            //    Console.WriteLine(val.Name +' '+val.Gender);
            //}

            //SelectMany
            //IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects);
            //IEnumerable<string> subjects = from student in Student.GetAllStudents()
            //    from subject in student.Subjects
            //    select subject;

            //foreach (var subject in subjects)
            //{
            //    Console.WriteLine(subject);
            //}

            //string[] str =
            //{
            //    "ABCDEFGHIJKL",
            //    "0123456789"
            //};

            //IEnumerable<char> s = str.SelectMany(x => x);
            //foreach (var c in s)
            //{
            //    Console.WriteLine(c);
            //}

            //IEnumerable<char> characters = from s in str
            //                      from c in s
            //                    select c;
            //foreach (var c in characters)
            //{
            //    Console.WriteLine(c);
            //}

            //IEnumerable<string> subjects = Student.GetAllStudents().SelectMany(s => s.Subjects).Distinct();
            //IEnumerable<string> subjectValue = (from student in Student.GetAllStudents()
            //    from subject in student.Subjects
            //    select subject).Distinct();
            //foreach (var subject in subjectValue)
            //{
            //    Console.WriteLine(subject);
            //}

            //var subjects = Student.GetAllStudents()
            //    .SelectMany(s => s.Subjects,
            //        (student, subject) => new {studentName = student.Name, GenderName = student.Gender});

            //var subjects = from student in Student.GetAllStudents()
            //               from subject in student.Subjects
            //               select new { studentName = student.Name, GenderName = student.Gender };
            //foreach (var item in subjects)
            //{
            //    Console.WriteLine(item.studentName + ' ' + item.GenderName);
            //}

            #endregion

            #region orderBy

            //IEnumerable<Student> studentNames = Student.GetAllStudents().OrderBy(x => x.Name);
            //IEnumerable<Student> studentNames = Student.GetAllStudents().OrderByDescending(x => x.Name);
            //IOrderedEnumerable<Student> studentNames = from student in Student.GetAllStudents()
            //    orderby student.Name
            //    select student;
            //IOrderedEnumerable<Student> studentNames = from student in Student.GetAllStudents()
            //                                           orderby student.Name descending 
            //                                           select student;
            //foreach (var name in studentNames)
            //{
            //    Console.WriteLine(name.Name);
            //}

            //IOrderedEnumerable<Student> students =
            //    Student.GetAllStudents().OrderBy(x => x.Name).ThenByDescending(x=>x.TotalMarks).ThenByDescending(x=>x.Id);
            //IOrderedEnumerable<Student> students = from student in Student.GetAllStudents()
            //    orderby student.Name, student.TotalMarks, student.Id descending 
            //    select student;
            //foreach (var value in students)
            //{
            //    Console.WriteLine("Name:" + value.Name + "\tTotal Marks:" + value.TotalMarks + "\tId:" + value.Id );
            //}

            //IEnumerable<Student> students = Student.GetAllStudents();
            //Console.WriteLine("Before calling");
            //foreach (var val in students)
            //{
            //    Console.WriteLine(val.Id);
            //}
            //Console.WriteLine("after calling");
            //var studentsList =students.Reverse();
            //foreach (var val in studentsList)
            //{
            //    Console.WriteLine(val.Id);
            //}

            #endregion

            #region take,skip,takewhile,skipwhile

            string[] countries = { "India", "Australia", "China", "USA", "Japan", "Korea" };
            //IEnumerable<string> result = countries.Take(3);
            //IEnumerable<string> result = (from country in countries
            //    select country).Take(3);

            //IEnumerable<string> result = countries.Skip(3);
            //IEnumerable<string> result = (from country in countries
            //                              select country).Skip(3);

            //IEnumerable<string> result = countries.TakeWhile(x=>x.Length>3);
            //IEnumerable<string> result = countries.SkipWhile(x => x.Length > 3);
            //foreach (var val in result)
            //{
            //    Console.WriteLine(val);
            //}
            //do
            //{
            //    IEnumerable<Student> students = Student.GetAllStudents();
            //    Console.WriteLine("please enter the page number between 1 to 4");
            //    int pageNumber = 0;
            //    if (int.TryParse(Console.ReadLine(), out pageNumber))
            //    {
            //        if (pageNumber >= 1 && pageNumber <= 4)
            //        {
            //            int pageSize = 3;
            //            IEnumerable<Student> result = students.Skip((pageNumber - 1)*pageSize).Take(pageSize);
            //            Console.WriteLine();
            //            Console.WriteLine("Displaying Page" + pageNumber);
            //            foreach (var student in result)
            //            {
            //                Console.WriteLine("Name:" + student.Name + "\tTotalMarks:" + student.TotalMarks);
            //            }
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("please enter the page number between 1 to 4");
            //        }
            //    }
            //} while (1 == 1);
            #endregion

            #region deferred execution


            //IEnumerable<Student> students = (from student in Student.GetAllStudents()
            //    where student.TotalMarks == 100
            //    select student).ToList();


            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.Name);
            //}
            #endregion

            #region GroupBy

            //var employeeGroups = Employee.GetAllEmployees().GroupBy(x => x.Department);

            //var employeeGroups = from employee in Employee.GetAllEmployees()
            //                     group employee by employee.Department into eGroup
            //                     orderby eGroup.Key
            //                     select new
            //                     {
            //                         Key = eGroup.Key,
            //                         Employees = eGroup.OrderBy(x=>x.Name)
            //                     };

            //foreach (var group in employeeGroups)
            //{
            //    //Console.WriteLine("{0}-{1}", group.Key, group.Count(x => x.Gender=="Female"));
            //    Console.WriteLine("{0}-{1}", group.Key, group.Employees.Count());
            //    foreach (var employee in group.Employees)
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.Department);
            //    }
            //    Console.WriteLine();
            //}

            //var employeeGroups = Employee.GetAllEmployees().GroupBy(x => x.Department);

            //var employeeGroups = Employee.GetAllEmployees()
            //    .GroupBy(x => new { x.Department, x.Gender })
            //    .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
            //    .Select(g => new
            //    {
            //        Dept = g.Key.Department,
            //        Gender = g.Key.Gender,
            //        Employees = g.OrderBy(x => x.Name)
            //    });            

            //var employeeGroups = from employee in Employee.GetAllEmployees()
            //    group employee by new {employee.Department, employee.Gender}
            //    into eGroup
            //    orderby eGroup.Key.Department, eGroup.Key.Gender
            //    select new
            //    {
            //        Dept = eGroup.Key.Department,
            //        Gender = eGroup.Key.Gender,
            //        Employees = eGroup.OrderBy(x => x.Name)
            //    };
            //foreach (var group in employeeGroups)
            //{
            //    Console.WriteLine("{0} Department {1} Gender {2}Count",
            //        group.Dept, group.Gender, group.Employees.Count());
            //    Console.WriteLine("--------------------");
            //    foreach (var employee in group.Employees)
            //    {
            //        Console.WriteLine(employee.Name + "\t" + employee.Gender + "\t" + employee.Department);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region GroupJoin

            //var employeesbyDepartments = Department.GetAlldepartments()
            //    .GroupJoin(Emp.GetAllEmployees(),
            //        d => d.Id,
            //        e => e.DepartmentId,
            //        (department, employee) => new
            //        {
            //            Department = department,
            //            Employees = employee 
            //        }
            //    );
            //var employeesbyDepartments = from department in Department.GetAlldepartments()
            //                             join employee in Emp.GetAllEmployees() on department.Id equals employee.DepartmentId into eGroup
            //                             select new
            //                             {
            //                                 Department = department,
            //                                 Employees = eGroup
            //                             };

            //foreach (var department in employeesbyDepartments)
            //{
            //    Console.WriteLine(department.Department.Name);
            //    foreach (var employee in department.Employees)
            //    {
            //        Console.WriteLine(" " + employee.EmployeeName);
            //    }
            //}

            #endregion

            #region InnerJoin

            //var employees = Emp.GetAllEmployees().Join(Department.GetAlldepartments(),
            //    e => e.DepartmentId,
            //    d => d.Id, 
            //    (employee, department)=> new
            //    {
            //        EmployeeName = employee.EmployeeName,
            //        DepartmentName = department.Name
            //    }
            //);
            //var employees = from emp in Emp.GetAllEmployees()
            //                join dept in Department.GetAlldepartments()
            //                on emp.DepartmentId equals dept.Id
            //                select new
            //                {
            //                    EmployeeName = emp.EmployeeName,
            //                    DepartmentName = dept.Name
            //                };
            //foreach (var result in employees)
            //{
            //    Console.WriteLine(result.EmployeeName + "\t" + result.DepartmentName);
            //}

            #endregion

            #region CrossJoin

            //var employees = from d in Department.GetAlldepartments()
            //                from e in Emp.GetAllEmployees()
            //                select new { e, d };
            //var employees = Emp.GetAllEmployees().SelectMany(e => Department.GetAlldepartments(),
            //    (e, d) => new {e, d});

            //var employees = Emp.GetAllEmployees().Join(Department.GetAlldepartments(),
            //    e => true,
            //    d => true,
            //    (e, d) => new {e, d});
            //foreach (var value in employees)
            //{
            //    Console.WriteLine(value.e.EmployeeName + '\t' + value.d.Name);
            //}

            #endregion

            #region Sets(Distinct)

            //string[] countriesList = {"USA", "India", "india", "Korea","Korea"};
            //var result = countriesList.Distinct();
            //var result1 = countriesList.Distinct(StringComparer.OrdinalIgnoreCase);
            //foreach (var val in result1)
            //{
            //    Console.WriteLine(val);
            //}

            //var employees = Emp.GetAllEmployees();
            ////var result = employees.Distinct();//default distinct doesnt work
            ////var result = employees.Distinct(new EmployeeComparer()); 
            //var result = employees.Select(x => new {x.EmployeeId, x.EmployeeName, x.DepartmentId}).Distinct();
            //foreach (var val in result)
            //{
            //    Console.WriteLine(val.EmployeeName);
            //}

            #endregion

            #region Sets(Union,Except,Intersect)

            //int[] num1 = {1, 2, 3, 4, 5};
            //int[] num2 = {1, 3, 6, 7, 9};

            //var result = num1.Union(num2);
            //List<Emp> emp= new List<Emp>()
            //{
            //    new Emp() {EmployeeId = 1, EmployeeName = "Divya", DepartmentId = 1},
            //    new Emp() {EmployeeId = 2, EmployeeName = "Kavya", DepartmentId = 1}
            //};
            //List<Emp> emp2 = new List<Emp>()
            //{
            //    new Emp() {EmployeeId = 1, EmployeeName = "Divya", DepartmentId = 1}
            //};
            //var result =
            //    emp.Select(x => new {x.EmployeeId, x.EmployeeName, x.DepartmentId})
            //        .Union(emp2.Select(x => new {x.EmployeeId, x.EmployeeName, x.DepartmentId}));
            //var result =
            //    emp.Select(x => new { x.EmployeeId, x.EmployeeName, x.DepartmentId })
            //        .Intersect(emp2.Select(x => new { x.EmployeeId, x.EmployeeName, x.DepartmentId }));
            //var result =
            //    emp.Select(x => new { x.EmployeeId, x.EmployeeName, x.DepartmentId })
            //        .Except(emp2.Select(x => new { x.EmployeeId, x.EmployeeName, x.DepartmentId }));
            //foreach (var value in result)
            //{
            //    Console.WriteLine(value);
            //}
            #endregion

            #region GenerationOperators(Range, Repeat, Empty)

            //IEnumerable<int> val = Enumerable.Range(1, 20).Where(x=>x%2==0);
            //var val = Enumerable.Repeat("Hello", 10);
            //var val = GetData() ?? Enumerable.Empty<int>();
            //foreach (var v in val)
            //{
            //    Console.WriteLine(v);
            //}
            #endregion

            #region Cancat

            //int[] i1 = {1, 2, 3, 4};
            //int[] i2 = {1, 3, 4};
            //var result = i1.Concat(i2);
            //foreach (var val in result)
            //{
            //    Console.WriteLine(val);
            //}

            #endregion

            #region SequenceEqual

            //string[] st1 = {"USA", "India", "Canada"};
            //string[] st2 = {"USA", "India", "canada"};
            //var result = st1.SequenceEqual(st2,StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine(result);

            #endregion

            #region Quantifiers

            int[] num1 = {1, 2, 3, 4, 5};
            string[] val = { "USA", "India"};
            var result = num1.All(x => x < 10);
            //var result = num1.Any();
            //var result = num1.Any(x=>x<10);
            //var result = num1.Contains(3);
            var g = val.Contains("usa", StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(result);

            #endregion

            Console.Read();
        }

        public static IEnumerable<int> GetData()
        {
            return null;
        }
    }
}
