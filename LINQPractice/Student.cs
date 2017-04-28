using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class Student
    {
        public int Id { get; set; }
        public  string Name{ get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student() {Id=1,Name = "Divya", Gender = "Female", Subjects = new List<string>() { "Maths,Physics"}, TotalMarks = 80},
                new Student() {Id=2,Name = "Kavya", Gender = "Female", Subjects = new List<string>() { "Chemistry,Physics"}, TotalMarks = 100},
                new Student() {Id=3,Name = "Sagnika", Gender = "Female", Subjects = new List<string>() { "Biology,Chemistry"},TotalMarks = 60},
                new Student() {Id=4,Name = "Neha", Gender = "Female", Subjects = new List<string>() { "Maths, Computers"},TotalMarks = 90},
                new Student() {Id=5,Name = "Divya", Gender = "Female", Subjects = new List<string>() { "Maths,Physics,Chemistry"}, TotalMarks = 100},
                new Student() {Id=6,Name = "Sagnika", Gender = "Female", Subjects = new List<string>() { "Biology,Chemistry"},TotalMarks = 60},
                new Student() {Id=7,Name = "Neha", Gender = "Female", Subjects = new List<string>() { "Maths, Computers"},TotalMarks = 90},
                new Student() {Id=8,Name = "Divya", Gender = "Female", Subjects = new List<string>() { "Maths,Physics,Chemistry"}, TotalMarks = 100},
                new Student() {Id=9,Name = "Sagnika", Gender = "Female", Subjects = new List<string>() { "Biology,Chemistry"},TotalMarks = 60},
                new Student() {Id=10,Name = "Neha", Gender = "Female", Subjects = new List<string>() { "Maths, Computers"},TotalMarks = 90},
                new Student() {Id=11,Name = "Divya", Gender = "Female", Subjects = new List<string>() { "Maths,Physics,Chemistry"}, TotalMarks = 100},
                new Student() {Id=12,Name = "Sagnika", Gender = "Female", Subjects = new List<string>() { "Biology,Chemistry"},TotalMarks = 60}
            };

            return studentList;
        } 
    }
}
