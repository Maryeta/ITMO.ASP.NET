using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET.MyApp.Models
{
    public class SampleContext: DbContext
    {
        public SampleContext(): base("StudentsDB") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Progress> Progresses { get; set; }
    }
}