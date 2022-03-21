using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MyApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public string NumGroup { get; set; }
        public virtual List<Subject> Subjects { get; set; }

        public Student() { }
        public Student (string firstName, string lastName, string numGroup)
        {
            FirstName = firstName;
            LastName = lastName;
            NumGroup = numGroup;
            Subjects = new List<Subject>();
        }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal NumHours { get; set; }
        public virtual List<Student> Students { get; set; }
        public Subject() { }
        public Subject(string name, decimal numHours)
        {
            Name = name;
            NumHours = numHours;
            Students = new List<Student>();
        }
    }

    public class Progress
    {
        public int ProgressId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subjects { get; set; }
        public virtual Student Students { get; set; }
        public int Grade { get; set; }

        public Progress() { }
        public Progress(Student st, Subject sub, int grade)
        {
            Grade = grade;
            Subjects = sub;
            Students = st;
        }
    }
}