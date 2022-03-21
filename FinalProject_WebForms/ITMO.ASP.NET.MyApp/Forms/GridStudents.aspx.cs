using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITMO.ASP.NET.MyApp.Models;

namespace ITMO.ASP.NET.MyApp.Forms
{
    public partial class GridStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleContext dbStudent = new SampleContext();
            var query = from st in dbStudent.Students
                        join pr in dbStudent.Progresses on st.StudentId equals pr.StudentId
                        join sb in dbStudent.Subjects on pr.SubjectId equals sb.SubjectId
                        
                        orderby sb.Name, st.StudentId
                        
                        select new 
                        { 
                            IdStudent = st.StudentId,
                            FirstName = st.FirstName,
                            LastName = st.LastName,
                            SubjectName = sb.Name,
                            Mark = pr.Grade
                        };
            
            GridView.DataSource = query.ToList();
            GridView.DataBind();
        }
    }
}