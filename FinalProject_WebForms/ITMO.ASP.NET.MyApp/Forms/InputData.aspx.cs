using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITMO.ASP.NET.MyApp.Models;

namespace ITMO.ASP.NET.MyApp.Forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleContext dbContext = new SampleContext();
            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                return;
                try
                {
                    Student newSt = new Student(FirstName.Text, LastName.Text, Group.Text);
                    dbContext.Students.Add(newSt);
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Response.Redirect("Ошибка" + ex.Message);
                }

                Response.Redirect("~/Forms/StudentAdded.aspx");
            }
        }
    }
}