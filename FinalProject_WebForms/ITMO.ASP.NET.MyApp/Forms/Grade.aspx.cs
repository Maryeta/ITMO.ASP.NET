using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITMO.ASP.NET.MyApp.Models;
using System.Data.Entity;

namespace ITMO.ASP.NET.MyApp.Forms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                SampleContext dbStudent = new SampleContext();
                List<Subject> subList = dbStudent.Subjects.ToList();

                foreach (var s in subList)
                {
                    ListSubject.Items.Add(s.Name);
                }

            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;

                try
                {
                    Subject subSelected = new Subject();

                    foreach (var s in subList)
                    {
                        if (s.Name == ListSubject.SelectedValue)
                        {
                            subSelected = s;
                        }
                    }

                    Student needStudent = new Student();
                    int studentId = int.Parse(TextBoxID.Text);
                    List<Student> students = dbStudent.Students.ToList();

                    foreach (var st in students)
                    {
                        if (st.StudentId == studentId)
                        {
                            needStudent = st;
                        }
                    }

                    Progress prog = new Progress(needStudent, subSelected, int.Parse(TextBoxGrade.Text));
                    dbStudent.Progresses.Add(prog);

                    dbStudent.SaveChanges();
                }
                catch (Exception ex)
                {
                    Response.Redirect("Ошибка" + ex.Message);
                }
                Response.Redirect("~/Forms/GradeAdded.aspx");
                
                
            }
        }
    }
}