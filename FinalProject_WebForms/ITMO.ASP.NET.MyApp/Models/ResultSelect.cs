using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP.NET.MyApp.Models
{
    public class ResultSelect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        SampleContext dbStudents = new SampleContext();

        public ResultSelect() { }
        public ResultSelect(int id, string name, string lastName, int grade)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.Grade = grade;

        }

        public List<ResultSelect> GetResultSelect()
        {
            var joinQuery = from pr in dbStudents.Progresses
                                join st in dbStudents.Students on pr.StudentId equals st.StudentId
                                select new
                                {
                                    id = pr.StudentId,
                                    name = st.FirstName,
                                    lastName = st.LastName,
                                    grade = pr.Grade
                                };

            var groupQuery = from res in joinQuery
                                 group res by new {id = res.id, name = res.name, lastName = res.lastName}
                                 into studGroup
                                 select new {id = studGroup.Key.id, name = studGroup.Key.name, lastName = studGroup.Key.lastName, Sum = studGroup.Sum(stG => stG.grade)};

            var sortQuery = from sort in groupQuery
                                 orderby sort.Sum ascending
                                 select sort;

            List < ResultSelect > resultList = new List<ResultSelect>();
            foreach (var s in sortQuery)
            {
                ResultSelect op = new ResultSelect(s.id, s.name, s.lastName, s.Sum);
                resultList.Add(op);
            }
            return resultList;
        }

        
    }
}