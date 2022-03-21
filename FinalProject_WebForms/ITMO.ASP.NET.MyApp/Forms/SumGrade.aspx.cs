using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITMO.ASP.NET.MyApp.Models;

namespace ITMO.ASP.NET.MyApp.Forms
{
    public partial class SumGrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResultSelect sumOperation = new ResultSelect();
            GridViewSum.DataSource = sumOperation.GetResultSelect();
            GridViewSum.DataBind();
        }
    }
}