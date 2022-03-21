using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITMO.ASP.NET.MyApp.Models;

namespace ITMO.ASP.NET.MyApp.Forms
{
    public partial class AllStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleContext dbStudent = new SampleContext();
            var query = from st in dbStudent.Students
                        select st;


            GridViewAllStudents.DataSource = query.ToList();
            GridViewAllStudents.DataBind();
        }
    }
}