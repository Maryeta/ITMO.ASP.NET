using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET.MyApp.Models
{
    public class StudentsDbInitializer: DropCreateDatabaseIfModelChanges<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            context.Subjects.Add(new Subject("Технологии программирования", 68));
            context.Subjects.Add(new Subject("Введение в базы данных", 73));
            context.Subjects.Add(new Subject("Программирование на С#", 70));
            context.Subjects.Add(new Subject("Transact-SQL и разработка Microsoft SQL Server", 80));
            base.Seed(context);
        }
    }
}